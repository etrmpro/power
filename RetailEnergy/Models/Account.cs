using System.Collections.Generic;

namespace RetailEnergy.Models
{
    public class Account : AbstractModel
    {
        public int AccountId { get; set; }
        public string Name { get; set; }
        public List<ServiceLocation> ServiceLocations { get; set; }
    }
}
