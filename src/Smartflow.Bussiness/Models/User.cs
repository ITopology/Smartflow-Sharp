﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Smartflow.Bussiness.Models
{
    public class User
    {
        public string ID
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public string OrganizationCode
        {
            get;
            set;
        }

        public string OrganizationName
        {
            get;
            set;
        }
    }
}
