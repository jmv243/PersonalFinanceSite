﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinanceSite.Contracts.Types
{
    public class LoginCredentials
    {
        public string EmailOrUserName { get; set; }
        public string Password { get; set; }
    }
}
