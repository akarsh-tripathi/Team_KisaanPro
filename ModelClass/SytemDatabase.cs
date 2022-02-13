using System;

namespace Team_KisaanPro.ModelClass
{
    public class SytemDatabase
    {
        public Guid ID { get; set; }
        public DateTime DateTime { get; set; }
        public string DeviceId { get; set; }
        public int Temperature { get; set; }
        public string phLevel { get; set; }
        public int Humidity { get; set; }
        public string DeviceStatus { get; set;}

       
    }
}
