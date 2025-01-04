namespace SCSIMS.Services.Factory;

public static class ServiceFactory
{
    private static Dictionary<string, IService> srvcDict = new(capacity: 8);

    public static void Add(string name, IService service)
    {
        srvcDict.Add(name, service);
    }

    public static dynamic Get(string name)
    {
        if (!srvcDict.ContainsKey(name))
        {
            throw new Exception($"No available service named {name}!");
        }

        return srvcDict[name];
    }
}
