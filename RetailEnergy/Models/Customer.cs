using System.Collections.Generic;

namespace RetailEnergy.Models
{
    public class Customer : AbstractModel
    {
        public int CustomerId { get; set; }
        public List<Account> Accounts { get; set; }
    }
}
