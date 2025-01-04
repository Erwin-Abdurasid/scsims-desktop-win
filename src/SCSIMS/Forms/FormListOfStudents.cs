namespace SCSIMS.Forms;

public partial class FormListOfStudents : Form
{
    // Dependencies
    private readonly ILoadingService _loadSrvc;
    private readonly IDbService _dbSrvc;
    private readonly IFilterService _filterSrvc;

    // Fields
    private bool _forceRefresh = false;
    private IEnumerable<Course>? _courses;
    private IEnumerable<StudentsDataViewModel>? _array = null;
    private Dictionary<int, StudentData> _memoArray = new Dictionary<int, StudentData>();

    public FormListOfStudents()
    {
        InitializeComponent();

        // Initializing Dependencies
        _loadSrvc = ServiceFactory.Get(nameof(ILoadingService));
        _dbSrvc = ServiceFactory.Get(nameof(IDbService));
        _filterSrvc = ServiceFactory.Get(nameof(IFilterService));

        InitControls();
    }

    private void FormListOfStudents_Load(object? sender, EventArgs e)
    {
        btnRefresh_Click(sender, e);
    }

    private void InitControls()
    {
        splitMain.Panel1Collapsed = true;
        InitComboCourse().Await(null,
            (ex) =>
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        );
    }

    private void btnRefresh_Click(object? sender, EventArgs e)
    {
        // Reloading data progress indicator
        IProgress<bool> progress = new Progress<bool>((comp) =>
        {
            // Events raised
            Thread newThread = new Thread(delegate ()
            {
                _loadSrvc.OnLoadingWithProgressStarted(comp);
            });
            newThread.Start();
        });

        CancellationToken token = _loadSrvc.TokenSource.Token;

        ReloadData(progress, token).Await(null,
            (ex) =>
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        );
    }

    private void filterToolStripMenuItem_Click(object? sender, EventArgs e)
    {
        FilterOpen(true);
    }

    private void lblFilterExit_Click(object? sender, EventArgs e)
    {
        FilterOpen(false);
    }

    // Occurs when opening filter view
    private void FilterOpen(bool open)
    {
        bool collapsed = !open;

        splitMain.Panel1Collapsed = collapsed;
        splitMain.SplitterDistance = collapsed ? 0 : 250;
        panelFilter.Enabled = open;
        panelFilter.Visible = open;
    }

    private void lblFilterExit_MouseHover(object? sender, EventArgs e)
    {
        if (sender != null)
        {
            ViewButtonHover(sender, Color.Black, Color.White);
        }
    }

    private void lblFilterExit_MouseLeave(object? sender, EventArgs e)
    {
        if (sender != null)
        {
            ViewButtonHover(sender, Color.White, Color.Transparent);
        }
    }

    // Occurs when hovering over view exit
    private void ViewButtonHover(object? sender, Color fore, Color back)
    {
        Control? control = sender as Control;

        if (control != null)
        {
            control.ForeColor = fore;
            control.BackColor = back;
        }
    }

    private void dateBDate_ValueChanged(object? sender, EventArgs e)
    {
        dateBDate.CustomFormat = "MMMM dd, yyyy";
    }

    private void Controls_KeyDown(object? sender, KeyEventArgs e)
    {
        if (sender != null)
        {
            method.GoToNextInputControl((Form)this, (Control)sender, e);
        }
    }

    // When applying filter to the data
    private void btnSubmit_Click(object sender, EventArgs e)
    {
        // Reloading data progress indicator
        IProgress<bool> progress = new Progress<bool>((comp) =>
        {
            // Events raised
            Thread newThread = new Thread(delegate ()
            {
                _loadSrvc.OnLoadingWithProgressStarted(comp);
            });
            newThread.Start();
        });

        CancellationToken token = _loadSrvc.TokenSource.Token;

        FilterData(progress, token).Await(null,
            (ex) =>
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        );
    }

    private async Task FilterData(IProgress<bool> progress, CancellationToken token)
    {
        try
        {
            // Reporting progress of Task
            progress.Report(false);

            // Assigning value for filtering in the filter service.
            _filterSrvc.FirstName = txtFName.Text;
            _filterSrvc.Midname = txtMName.Text;
            _filterSrvc.LastName = txtLName.Text;
            _filterSrvc.ExtName = txtEName.Text;
            _filterSrvc.Course = comboCourse.Text;
            _filterSrvc.Gender = comboGender.Text;
            // For year level
            string tempYrLvl = comboYrLvl.Text switch
            {
                null or "" or " " => "0",
                "Graduated" => "6",
                _ => comboYrLvl.Text
            };
            _filterSrvc.YearLevel = byte.Parse(tempYrLvl);
            // For date
            _filterSrvc.Date = dateBDate.Text;

            IEnumerable<StudentsDataViewModel>? resTempData = new List<StudentsDataViewModel>();

            resTempData = _filterSrvc.FilterNow(_array);

            if (resTempData != null)
            {
                await PopulateFlowPanel(resTempData, token);
            }
        }
        finally
        {
            // Reporting progress of Task
            progress.Report(true);
        }
    }

    // When reloading the data is required
    private async Task ReloadData(IProgress<bool> progress, CancellationToken token, bool filter = false)
    {
        try
        {
            // Reporting progress of Task
            progress.Report(false);

            if (_forceRefresh || await _dbSrvc.RefreshableAsync())
            {
                _array = await _dbSrvc.ReadToDisplayAsync();

                if (_array != null)
                {
                    await PopulateFlowPanel(_array, token);
                }
            }
        }
        finally
        {
            // Reporting progress of Task
            progress.Report(true);
        }
    }

    private async Task PopulateFlowPanel(IEnumerable<StudentsDataViewModel> newArray, CancellationToken token)
    {
        List<StudentData> students = new List<StudentData>(newArray.Count());

        // Ensuring the memo can cope up with the length of the array.
        if (!_memoArray.Any() ||
            (_array != null && _array.Any() && _memoArray.Count < _array.Count()))
        {
            _memoArray.EnsureCapacity(newArray.Count());
        }

        foreach (StudentsDataViewModel student in newArray)
        {
            // Cancelling
            if (token.IsCancellationRequested)
            {
                break;
            }

            // If the data doesn't exist in memo, make it and store it in for
            // future need. Otherwise, only get what is in memo for efficiency.
            if (_memoArray.Any(d => d.Key == student.Id!.Value))
            {
                students.Add(_memoArray.First(d => d.Key == student.Id!.Value).Value);
            }
            else
            {
                StudentData studentData = new StudentData(student);
                students.Add(studentData);
                _memoArray.Add(student.Id!.Value, studentData);
            }

            // To show the loading
            await Task.Delay(1);
        }

        flowData.Controls.Clear();
        flowData.Controls.AddRange(students.ToArray());
        flowData.Refresh();
    }

    private async Task InitComboCourse()
    {
        comboCourse.Items.Clear();

        _courses = await _dbSrvc.GetCoursesAsync();

        if (_courses != null)
        {
            foreach (Course course in _courses)
            {
                comboCourse.Items.Add($"{course.Name} ({course.Abbr})");
            }
        }
    }

    // Indicate whether to force refresh or not
    private void checkForce_CheckedChanged(object? sender, EventArgs e)
    {
        if (checkForce.CheckState == CheckState.Checked)
        {
            _forceRefresh = true;
        }
        else
        {
            _forceRefresh = false;
        }
    }

    // Indicate when selecting more
    private void checkSelect_CheckedChanged(object sender, EventArgs e)
    {
        if (checkSelect.CheckState == CheckState.Checked)
        {
            TurnOnDOrD(true);
        }
        else
        {
            TurnOnDOrD(false);
        }
    }

    private void TurnOnDOrD(bool on)
    {
        btnOpt.Enabled = on;
        btnOpt.Visible = on;
        checkSelectAll.Enabled = on;
        checkSelectAll.Visible = on;
    }
}