using Microsoft.Data.SqlClient;

namespace MyWebAppCore.Models
{
    public class db
    {
        SqlConnection con;

        public db()
        {
            var configuation = GetConfiguration();
            con = new SqlConnection(configuation.GetSection("Data").GetSection("ConnectionString").Value);
        }

        public IConfigurationRoot GetConfiguration()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            return builder.Build();
        }
    }
}
