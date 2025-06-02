void ModifyRef(ref int x)
{
    x = x + 10;
}

int a = 5;

Console.WriteLine($"before :{a}");

ModifyRef(ref a);

Console.WriteLine($"after :{a}");

//ModifyRef(ref a);

Console.WriteLine($"after :{a}");



public class AppConfig
{
    public static string AppName;
    public static string Version;

    // Static Constructor
    static AppConfig()
    {

        Console.WriteLine("Static constructor called.");
        AppName = "MyEnterpriseApp";
        Version = "1.0.0";
    }

    public static void ShowConfig()
    {

        Console.WriteLine($"App: {AppName}, Version: {Version}");
    }
}

