﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Smartflow
{
    public interface IWorkflowLinkService
    {
        int GetLink(string id, string instanceID);
    }
}
