
using Microsoft.Extensions.Configuration;

namespace ECommerceOnionProject.Persistence.Configurations;

public class ConnectionString
{
    public static string Configure()
    {
        ConfigurationManager configurationManager = new();
        configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/ECommerceOnionProject.WebAPI"));
        configurationManager.AddJsonFile("appsettings.json");
        return configurationManager.GetConnectionString("PostgreSQL")!;
    }
}
