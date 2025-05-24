using System.Configuration;

public class DbConstants
{

    public static string ConnectionString
    {
        get
        {
            return ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
        }
    }
    public static string spGetCategories = "uspGetCategories";

    

}