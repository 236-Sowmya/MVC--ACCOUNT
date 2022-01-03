using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC__ACCOUNT.Models
{
    public class Account
    {
        public int ID { get; set; }
        public string AccountHolderName { get; set; }

        public string AccountHolderAddress { get; set; }
    }
}
