using Dapper;
using System.Data;
using System.Data.SqlClient;
using Team_KisaanPro.IServices;
using Team_KisaanPro.ModelClass;

namespace Team_KisaanPro.Services
{
    public class DataService : IDataService
    {
        Database _oDatabase= new Database();
        UserDatabase _oUserDatabase= new UserDatabase();

        public Database GetSystemDatabase()
        {
            _oDatabase=new Database();
            using (IDbConnection con = new SqlConnection(Global.ConnectionString) )
            {
                if(con.State != ConnectionState.Open) con.Open();

                // Extracting All the List of Database in System Configuration
                var oDatabases = con.Query<Database>("").ToList();

                // Condition to Check if the Databse is empty or not

                if(oDatabases!=null && oDatabases.Count > 0)
                {
                    _oDatabase = oDatabases.FirstOrDefault();
                }

            }
            return _oDatabase;
        }

        public UserDatabase GetUserDatabase()
        {
            _oUserDatabase = new UserDatabase();
            using (IDbConnection con = new SqlConnection(Global.ConnectionString))
            {
                if (con.State != ConnectionState.Open) con.Open();

                // Extracting All the List of Database in User Database
                var oUserDatabases = con.Query<UserDatabase>("").ToList();

                // Condition to Check if the Databse is empty or not

                if (oUserDatabases != null && oUserDatabases.Count > 0)
                {
                    _oUserDatabase = oUserDatabases.FirstOrDefault();
                }

            }
            return _oUserDatabase;
        }

        public UserDatabase SaveToUserDatabase(UserDatabase ouserDatabase)
        {
            throw new NotImplementedException();
        }
    }
}
