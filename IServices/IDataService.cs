using Team_KisaanPro.ModelClass;

namespace Team_KisaanPro.IServices
{
    public interface IDataService
    {
        List<SytemDatabase> GetSystemDatabase(); 

        List<UserDatabase> GetUserDatabase();


    }
}
