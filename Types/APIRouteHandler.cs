/** 
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

namespace Limitless.Runtime.Types
{
    /// <summary>
    /// Defines a route handler for extending the Project Limitless API.
    /// </summary>
    public class APIRouteHandler
    {
        /// <summary>
        /// The route. See documentation on route formats at 
        /// https://docs.projectlimitless.io/ProjectLimitless/api-routes
        /// </summary>
        public string Route { get; set; } = "/";
        /// <summary>
        /// The handler function. Takes a dynamic object as input and
        /// returns a dynamic object.
        /// The method signature must be
        /// public dynamic MyHandler(dynamic input)
        /// </summary>
        public Func<dynamic, dynamic> Handler { get; set; } = (dynamic input) => { return $"Missing Handler"; };
    }
}
