using Team_KisaanPro.ModelClass;

namespace Team_KisaanPro.IServices
{
    public interface IDataService
    {
        List<SytemDatabase> GetSystemDatabase(); 

        List<UserDatabase> GetUserDatabase();

        List<DeviceDatabase> GetDeviceDatabase();

        public void AddDeviceToDatabase(string DeviceId, string Status);

    }
}
