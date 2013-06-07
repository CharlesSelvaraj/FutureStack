using ServiceStack.OrmLite;
namespace FutureStack.DataAccess.DBCreator
{
    using System.Configuration;
    using System.Data;
    using System.Data.Common;
    using System.Data.SqlClient;
    using DomainModel;
    using ServiceStack.OrmLite.SqlServer;


    class Program
    {
        static void Main(string[] args)
        {
            OrmLiteConfig.DialectProvider = new SqlServerOrmLiteDialectProvider();
            DbProviderFactory connectionFactory = SqlClientFactory.Instance;
            IDbConnection dbConnection = connectionFactory.CreateConnection();
            if (dbConnection != null) dbConnection.ConnectionString = ConfigurationManager.ConnectionStrings["FutureStackSQL"].ToString();

            CreateFutureStackDb(dbConnection);
        }

        private static void CreateFutureStackDb(IDbConnection dbConnection)
        {
           if( dbConnection.State != ConnectionState.Open) dbConnection.Open(); 
           dbConnection.DropAndCreateTable<Customer>();
           dbConnection.DropAndCreateTable<Address>();
        }
    }
}
