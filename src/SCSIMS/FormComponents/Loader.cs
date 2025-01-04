namespace SCSIMS.FormComponents;

public partial class Loader : Form
{
    // Dependencies
    private readonly ILoadingService _loadSrvc;

    public Loader()
    {
        InitializeComponent();

        // Initializing dependencies
        _loadSrvc = ServiceFactory.Get(nameof(ILoadingService));
    }

    private void lblCancel_Click(object sender, EventArgs e)
    {
        try
        {
            _loadSrvc.TokenSource.Cancel();
        }
        finally
        {
            _loadSrvc.TokenSource.Dispose();
            _loadSrvc.TokenSource = new CancellationTokenSource();
        }
    }
}
