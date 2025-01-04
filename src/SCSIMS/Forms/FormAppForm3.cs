namespace SCSIMS.Forms;

public partial class FormAppForm3 : Form
{
    // Forms
    private readonly FormAppForm2 _prevForm;

    // Dependencies
    private readonly IInputDataService _inputSrvc;
    private readonly IDbService _dbSrvc;
    private readonly ILoadingService _loadSrvc;

    public FormAppForm3()
    {
        InitializeComponent();

        // Initializing dependencies
        _prevForm = ServiceFactory.Get("Form 2");
        _inputSrvc = ServiceFactory.Get(nameof(IInputDataService));
        _dbSrvc = ServiceFactory.Get(nameof(IDbService));
        _loadSrvc = ServiceFactory.Get(nameof(ILoadingService));

        InitEvents();
        InitControls();
    }

    // Properties
    public FormDashboard? MdiParentForm { private get; set; }

    // Initializing events
    private void InitEvents()
    {
        _inputSrvc.ProcessToRun += DataSettingProcess;
    }

    // Initializing controls
    private void InitControls()
    {
        DateTime now = DateTime.Now;

        lblReviewer.Text =
@$"Please review all your inputs before submitting it. You can navigate backward to check all the previous inputs.

Your enrollment will include the following information:

✓ Date of enrollment: {now.ToLongDateString()}
✓ Time of enrollment: {now.ToLongTimeString()}

If something is wrong with the information, please review further your inputs. Make sure everything is correct!

Thank You!";
    }

    private void picPrev_Click(object? sender, EventArgs e)
    {
        _prevForm.Activate();
    }

    private void btnSubmit_Click(object? sender, EventArgs e)
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

        // Invoke event
        _inputSrvc.OnProcessToRun();

        if (_inputSrvc.CanUse)
        {
            AddAsync(_inputSrvc.StudentData!, progress, token).Await(null, (ex) =>
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            });
        }
    }

    private void btnClear_Click(object? sender, EventArgs e)
    {
        // Invoke event
        _inputSrvc.OnInputClear();

        MessageBox.Show(mess.Cleared, "Information",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void DataSettingProcess(object? sender, EventArgs e)
    {
        try
        {
            // Set the data
            _inputSrvc.SetFormAppForm3Data(DateTime.Now);
        }
        catch (Exception ex)
        {
            _inputSrvc.OnInputError();

            MessageBox.Show(ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async Task AddAsync(Student student, IProgress<bool> progress, CancellationToken token)
    {
        try
        {
            // Reporting progress of Task
            progress.Report(false);

            // Cancelling
            token.ThrowIfCancellationRequested();

            bool success = await _dbSrvc.AddNewAsync(student);

            // To show the loading
            await Task.Delay(1);

            // This is where data is added
            if (success)
            {
                MessageBox.Show(mess.Enrolled, "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Invoke clear event to clear all inputs
                _inputSrvc.OnInputClear();
            }
            else
            {
                throw new Exception(mess.UnEnrolled);
            }
        }
        finally
        {
            // Reporting progress of Task
            progress.Report(true);
        }
    }

    private void FormAppForm3_FormClosing(object sender, FormClosingEventArgs e)
    {
        _inputSrvc.ProcessToRun -= DataSettingProcess;
        MdiParentForm?.Dispose();
    }
}