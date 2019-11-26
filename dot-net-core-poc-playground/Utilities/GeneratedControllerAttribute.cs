using System;

namespace dot_net_core_poc_playground.Utilities
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class GeneratedControllerAttribute : Attribute
    {
        public string Route { get; set; }
        public GeneratedControllerAttribute(string route)
        {
            Route = route;
        }
    }
}
