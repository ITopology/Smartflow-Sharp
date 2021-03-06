﻿using Smartflow.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Smartflow.Internals
{
    internal class ServiceContainer
    {
        private static readonly Dictionary<string, Type> innerHandleMap = new Dictionary<string, Type>();

        static ServiceContainer()
        {
            innerHandleMap.Add("start", typeof(WorkflowNodeService));
            innerHandleMap.Add("end", typeof(WorkflowNodeService));
            innerHandleMap.Add("decision", typeof(WorkflowNodeService));
            innerHandleMap.Add("node", typeof(WorkflowNodeService));
            innerHandleMap.Add("fork", typeof(WorkflowNodeService));
            innerHandleMap.Add("merge", typeof(WorkflowNodeService));
            innerHandleMap.Add("form", typeof(WorkflowNodeService));
            innerHandleMap.Add("dynamic", typeof(WorkflowNodeService));


            innerHandleMap.Add("group", typeof(WorkflowGroupService));
            innerHandleMap.Add("command", typeof(WorkflowCommandService));
            innerHandleMap.Add("transition", typeof(WorkflowTransitionService));
            innerHandleMap.Add("actor", typeof(WorkflowActorService));
            innerHandleMap.Add("action", typeof(WorkflowActionService));

            innerHandleMap.Add("carbon", typeof(WorkflowCarbonService));
            innerHandleMap.Add("rule", typeof(WorkflowRuleService));
            innerHandleMap.Add("organization", typeof(WorkflowOrganizationService));
        }

        public static Object Resolve(string name)
        {
            Type innerType = innerHandleMap[name];
            return Utils.CreateInstance(innerType);
        }

        public static bool Contains(string name)
        {
            return innerHandleMap.ContainsKey(name);
        }
    }
}
