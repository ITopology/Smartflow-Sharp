﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Smartflow.Web.Models
{
    public class BridgeDto
    {
        public string InstanceID
        {
            get;
            set;
        }

        public string CategoryID
        {
            get;
            set;
        }

        public string Key
        {
            get;
            set;
        }

        public string Comment
        {
            get; set;
        }

        public string Creator
        {
            get;
            set;
        }

        public DateTime CreateDateTime
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }
    }
}