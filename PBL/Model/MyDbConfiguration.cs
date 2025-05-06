using System.Data.Entity;
using System.Data.Entity.SqlServer;

public class MyDbConfiguration : DbConfiguration
{
    public MyDbConfiguration()
    {
        SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy());
    }
}
