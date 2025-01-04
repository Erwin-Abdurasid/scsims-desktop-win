namespace SCSIMS.Forms;

public partial class FormDashboard : Form, IService
{
    // Forms
    private FormMain? _formMain = null;
    private FormAppForm1? _formEnroll = null;
    private FormListOfStudents? _formInfo = null;
    private Form? _bgForm = null;
    private AboutBox? _aboutDialog = null;
    private Loader? _loader = null;

    // Dependencies
    private readonly ILoadingService _loadSrvc;

    public FormDashboard()
    {
        InitializeComponent();

        // Initializing dependencies
        ServiceFactory.Add("Parent Form", this);
        _loadSrvc = ServiceFactory.Get(nameof(ILoadingService));

        InitEvents();
        InitControls();
    }

    private void FormDashboard_Load(object? sender, EventArgs e)
    {
        // First form to show
        btnHome_Click(sender, e);

        // Events raised
        Thread newThread = new Thread(delegate ()
        {
            _loadSrvc.OnLoadingStarted(500);
        });
        newThread.Start();
    }

    private void InitEvents()
    {
        _loadSrvc.LoadingStarted += LoaderOnOff;
    }

    public void InitControls()
    {
        if (_aboutDialog == null)
        {
            _aboutDialog = new AboutBox();
        }

        this.Text = $"Simple Computer Student Information Management System (Version {_aboutDialog.Version})";

        _aboutDialog.Dispose();
        _aboutDialog = null;
    }

    // Setting the side bar button as current.
    private void SetSideBarButtonBackColor(Color home, Color add, Color view)
    {
        btnHome.BackColor = home;
        btnAdd.BackColor = add;
        btnView.BackColor = view;
    }

    private void picLogo_MouseHover(object? sender, EventArgs e)
    {
        toolTipHome.SetToolTip(picLogo, "Home");
    }

    private void picLogo_Click(object? sender, EventArgs e)
    {
        btnHome_Click(sender, e);
    }

    private void btnHome_Click(object? sender, EventArgs e)
    {
        SetSideBarButtonBackColor(Color.Turquoise, Color.Gray, Color.Gray);

        if (_formMain == null)
        {
            _formMain = new FormMain();
            _formMain.FormClosed += _formMain_FormClosed;
            _formMain.MdiParent = this;
            _formMain.Dock = DockStyle.Fill;
            _formMain.Show();
        }
        else
        {
            _formMain.Activate();
        }
    }

    private void _formMain_FormClosed(object? sender, FormClosedEventArgs e)
    {
        _formMain?.Dispose();
        _formMain = null;
    }

    private void btnAdd_Click(object? sender, EventArgs e)
    {
        SetSideBarButtonBackColor(Color.Gray, Color.Turquoise, Color.Gray);

        if (_formEnroll == null)
        {
            _formEnroll = new FormAppForm1();
            _formEnroll.MdiParent = this;
            _formEnroll.FormClosed += _formEnroll_FormClosed;
            _formEnroll.Dock = DockStyle.Fill;
            _formEnroll.Show();
        }
        else
        {
            _formEnroll.Activate();
        }        
    }

    private void _formEnroll_FormClosed(object? sender, FormClosedEventArgs e)
    {
        _formEnroll?.Dispose();
        _formEnroll = null;
    }

    private void btnView_Click(object? sender, EventArgs e)
    {
        SetSideBarButtonBackColor(Color.Gray, Color.Gray, Color.Turquoise);

        if (_formInfo == null)
        {
            _formInfo = new FormListOfStudents();
            _formInfo.FormClosed += _formInfo_FormClosed;
            _formInfo.MdiParent = this;
            _formInfo.Dock = DockStyle.Fill;
            _formInfo.Show();
        }
        else
        {
            _formInfo.Activate();
        }
    }

    private void _formInfo_FormClosed(object? sender, FormClosedEventArgs e)
    {
        _formInfo?.Dispose();
        _formInfo = null;
    }

    private void lblCopyright_MouseHover(object? sender, EventArgs e)
    {
        toolTipQ.SetToolTip(lblCopyright, " ? ");
    }

    private void lblCopyright_Click(object? sender, EventArgs e)
    {
        if (_aboutDialog == null)
        {
            _aboutDialog = new AboutBox();
            _aboutDialog.FormClosed += _aboutDialog_FormClosed;
            _aboutDialog.Show();
        }
    }

    private void _aboutDialog_FormClosed(object? sender, FormClosedEventArgs e)
    {
        _aboutDialog?.Dispose();
        _aboutDialog = null;
    }

    private void LoaderOnOff(object? sender, LoadingEventArgs e)
    {
        try
        {
            if (_loader == null)
            {
                _loader = new Loader();
            }

            if (_bgForm == null)
            {
                _bgForm = new Form();
                InitializeBgForm(Color.White, 0.50d);
            }

            if (e.DisplayLoader)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    _bgForm!.Show();
                    _loader.Owner = _bgForm;
                    _loader.Show();
                });
            }
            else
            {
                this.Invoke((MethodInvoker)delegate
                {
                    _loader.Close();
                    _loader.Dispose();
                    _loader = null;
                    _bgForm?.Close();
                    _bgForm?.Dispose();
                    _bgForm = null;
                });
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void InitializeBgForm(Color backColor, double opacity)
    {
        if (_bgForm != null)
        {
            _bgForm.Size = this.Size;
            _bgForm.BackColor = backColor;
            _bgForm.Opacity = opacity;
            _bgForm.ControlBox = false;
            _bgForm.Cursor = Cursors.WaitCursor;
            _bgForm.FormBorderStyle = FormBorderStyle.None;
            _bgForm.ShowInTaskbar = false;
            _bgForm.StartPosition = FormStartPosition.CenterScreen;
            _bgForm.TopMost = false;
            _bgForm.WindowState = FormWindowState.Maximized;
        }
    }

    private void FormDashboard_FormClosing(object sender, FormClosingEventArgs e)
    {
        _loadSrvc.LoadingStarted -= LoaderOnOff;
        this.Dispose();
    }
}