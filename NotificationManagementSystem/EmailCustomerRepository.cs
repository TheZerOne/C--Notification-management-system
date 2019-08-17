using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationManagementSystem
{
    public class CustomerRepository
    {
        
        public  List<SendViaEmail> EmailCustomers { get; set; }
        public List<SendViaMobile> MobileCustomers { get; set; }

        public CustomerRepository()
        {
            EmailCustomers = new List<SendViaEmail>();
            MobileCustomers = new List<SendViaMobile>();
        }


    }
}
