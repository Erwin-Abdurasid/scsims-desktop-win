namespace SCSIMS;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // Dependencies Management
        ServiceFactory.Add(nameof(IDbService), new DbService());
        ServiceFactory.Add(nameof(IFilterService), new FilterService());
        ServiceFactory.Add(nameof(IInputDataService), new InputDataService());
        ServiceFactory.Add(nameof(ILoadingService), new LoadingService());
        ServiceFactory.Add(nameof(IValidationService), new ValidationService());
        
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new FormDashboard());
    }
}
