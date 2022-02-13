using Dapper;
using System.Data;
using System.Data.SqlClient;
using Team_KisaanPro.IServices;
using Team_KisaanPro.ModelClass;

namespace Team_KisaanPro.Services
{
    public class DataService : IDataService
    {
        List<SytemDatabase> _oDatabase;
        List<UserDatabase> _oUserDatabase;

        public List<SytemDatabase>? GetSystemDatabase()
        {
            using (IDbConnection con = new SqlConnection(Global.ConnectionString) )
            {
                if(con.State != ConnectionState.Open) con.Open();

                // Extracting All the List of Database in System Configuration
                _oDatabase = con.Query<SytemDatabase>("SELECT * FROM [dbo].[SytemDatabase]").ToList();

                // Condition to Check if the Databse is empty or not

                if(_oDatabase!=null && _oDatabase.Count > 0)
                {
                    return _oDatabase;
                }

            }
            return null;
        }

        public List<UserDatabase>? GetUserDatabase()
        {

            using (IDbConnection con = new SqlConnection(Global.ConnectionString))
            {
                if (con.State != ConnectionState.Open) con.Open();

                // Extracting All the List of Database in User Database
                _oUserDatabase = con.Query<UserDatabase>("SELECT * FROM [dbo].[UserDatabase]").ToList();

                // Condition to Check if the Databse is empty or not

                if (_oUserDatabase != null && _oUserDatabase.Count > 0)
                {
                    return _oUserDatabase;        
                }

            }
            return null;
        }

    }
}
