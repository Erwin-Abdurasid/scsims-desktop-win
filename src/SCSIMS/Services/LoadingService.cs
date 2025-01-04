namespace SCSIMS.Services;

public class LoadingService : ILoadingService, IService
{    
    // Events
    public event EventHandler<LoadingEventArgs>? LoadingStarted;

    // Property
    public CancellationTokenSource TokenSource { get; set; }

    public LoadingService()
    {
        TokenSource = new CancellationTokenSource();
    }

    public void OnLoadingStarted(int delayMS)
    {
        SetLoading(true);

        Thread.Sleep(delayMS);

        SetLoading(false);
    }

    public void OnLoadingWithProgressStarted(bool completed)
    {
        if (!completed)
        {
            SetLoading(true);
            return;
        }

        SetLoading(false);
    }

    private void SetLoading(bool displayLoader)
    {
        LoadingStarted?.Invoke(null, new LoadingEventArgs
        {
            DisplayLoader = displayLoader
        });
    }
}
