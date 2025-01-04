namespace SCSIMS.Extensions;

public static class AsyncAwaitExtension
{
    public static async void Await(this Task task, Action? sucCallback = null, Action<Exception>? errCallback = null)
    {
        try
        {
            await task;

            sucCallback?.Invoke();
        }
        catch (Exception ex)
        {
            errCallback?.Invoke(ex);
        }
    }

    public static async void Await(this ValueTask vTask, Action? sucCallback = null, Action<Exception>? errCallback = null)
    {
        try
        {
            await vTask;

            sucCallback?.Invoke();
        }
        catch (Exception ex)
        {
            errCallback?.Invoke(ex);
        }
    }
}
