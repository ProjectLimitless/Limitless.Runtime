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
using System.Collections.Generic;

using Limitless.Runtime.Types;

namespace Limitless.Runtime
{
    /// <summary>
    /// The interface required to be implemented by all modules
    /// that adds API routes to the Project Limitless API.
    /// </summary>
    public interface IAPIModule
    {
        /// <summary>
        /// Returns the list of available routes for the module.
        /// </summary>
        /// <returns>The list of routes</returns>
        List<APIRouteHandler> GetRoutes();
    }
}
