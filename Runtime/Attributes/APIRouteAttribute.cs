﻿/** 
* This file is part of Project Limitless.
* Copyright © 2016 Donovan Solms.
* Project Limitless
* https://www.projectlimitless.io
* 
* Project Limitless is free software: you can redistribute it and/or modify
* it under the terms of the Apache License Version 2.0.
* 
* You should have received a copy of the Apache License Version 2.0 with
* Project Limitless. If not, see http://www.apache.org/licenses/LICENSE-2.0.
*/

using System;

using Limitless.Runtime.Enums;

namespace Limitless.Runtime.Attributes
{
    /// <summary>
    /// Defines a method as being an API Route.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public class APIRouteAttribute : Attribute
    {
        /// <summary>
        /// The route's HTTP method.
        /// </summary>
        public HttpMethod Method { get; set; } = HttpMethod.Get;
        /// <summary>
        /// The route. See documentation on route formats at 
        /// TODO: https://docs.projectlimitless.io/ProjectLimitless/api-routes
        /// </summary>
        public string Path { get; set; }
        /// <summary>
        /// Get and sets if authentication for the route is required.
        /// </summary>
        public bool RequiresAuthentication { get; set; } = false;
        /// <summary>
        /// A description of the API route.
        /// </summary>
        public string Description { get; set; } = "Extended API Route";
        /// <summary>
        /// A list of fields required in the postData for methods using the 
        /// POST method.
        /// </summary>
        public string[] RequiredFields { get; set; } = new string[] { };
    }
}
