using System.Collections.Generic;

namespace RetailEnergy.Models
{
    public class ServiceLocation : AbstractModel
    {
        public int ServiceLocationId { get; set; }
        public Address Address { get; set; }
        public List<Meter> Meters { get; set; }
    }
}
