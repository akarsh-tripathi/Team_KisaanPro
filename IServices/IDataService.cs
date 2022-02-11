using Team_KisaanPro.ModelClass;

namespace Team_KisaanPro.IServices
{
    public interface IDataService
    {
        Database GetSystemDatabase(); 

        UserDatabase GetUserDatabase();
        UserDatabase SaveToUserDatabase(UserDatabase ouserDatabase);
    }
}
