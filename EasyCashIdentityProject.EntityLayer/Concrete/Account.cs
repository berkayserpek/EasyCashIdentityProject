﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.EntityLayer.Concrete
{
    public class Account
    {
        public int AccountID { get; set; }
        public string AccountNumber { get; set; }
        public string AccountCurrency { get; set; }
        public decimal AccountBalance { get; set; }
        public string BankBranch { get; set; }
        public int AppUserID { get; set; }
        public AppUser AppUser { get; set; }

    }
}
