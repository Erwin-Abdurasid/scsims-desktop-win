namespace SCSIMS.Services.Contracts;

public interface ILoadingService
{
    // Events
    event EventHandler<LoadingEventArgs> LoadingStarted;

    // Properties
    CancellationTokenSource TokenSource { get; set; }

    // Event Handlers
    void OnLoadingStarted(int delayMS);
    void OnLoadingWithProgressStarted(bool completed);
}
