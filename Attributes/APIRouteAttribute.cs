using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Limitless.Runtime.Attributes
{
    /// <summary>
    /// Defines a method as being an API Route.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public class APIRouteAttribute : Attribute
    {
        /// <summary>
        /// The route. See documentation on route formats at 
        /// https://docs.projectlimitless.io/ProjectLimitless/api-routes
        /// </summary>
        public string Path { get; set; }
    }
}
