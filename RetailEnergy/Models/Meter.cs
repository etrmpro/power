namespace RetailEnergy.Models
{
    public class Meter : AbstractModel
    {
        public int MeterId { get; set; }
        public string MeterNumber { get; set; }
        public ServiceLocation ServiceLocation { get; set; }
    }
}
