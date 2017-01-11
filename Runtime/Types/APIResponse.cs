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

namespace Limitless.Runtime.Types
{
    /// <summary>
    /// Defines a response from an API method.
    /// </summary>
    public class APIResponse
    {
        /// <summary>
        /// The HTTP status code to return.
        /// </summary>
        public int StatusCode { get; set; }
        /// <summary>
        /// The status message to return.
        /// </summary>
        public string StatusMessage { get; set; }
        /// <summary>
        /// Additional headers to return as a list of anonymous types.
        /// Format:
        ///     Header: "string",
        ///     Valule: "string
        /// </summary>
        public List<object> Headers { get; private set; }
        /// <summary>
        /// The data to return.
        /// </summary>
        public dynamic Data { get; set; }

        /// <summary>
        /// Standard constructor.
        /// </summary>
        public APIResponse()
        {
            StatusCode = 200;
            Headers = new List<object>();
        }

        /// <summary>
        /// Constructor with payload data.
        /// </summary>
        /// <param name="data">The payload data</param>
        public APIResponse(dynamic data)
        {
            StatusCode = 200;
            Headers = new List<object>();
            Data = data;
        }
    }
}
