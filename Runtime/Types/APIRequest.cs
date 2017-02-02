/** 
* This file is part of Project Limitless.
* Copyright © 2017 Donovan Solms.
* Project Limitless
* https://www.projectlimitless.io
* 
* Project Limitless is free software: you can redistribute it and/or modify
* it under the terms of the Apache License Version 2.0.
* 
* You should have received a copy of the Apache License Version 2.0 with
* Project Limitless. If not, see http://www.apache.org/licenses/LICENSE-2.0.
*/

using System.Collections.Generic;

namespace Limitless.Runtime.Types
{
    /// <summary>
    /// Defines a request to an API method.
    /// </summary>
    public class APIRequest
    {
        /// <summary>
        /// The request headers as a Nancy Header holder.
        /// </summary>
        public NancyRequestHeaders Headers { get; set; }
        /// <summary>
        /// Url parameters extracted by Nancy.
        /// </summary>
        public dynamic Parameters { get; set; }
        /// <summary>
        /// The parsed querystring as Name, Value pairs
        /// </summary>
        public Dictionary<string, string> QueryString { get; set; }
        /// <summary>
        /// Data sent for POST and PUT requests.
        /// </summary>
        public dynamic Data { get; set; }
        /// <summary>
        /// The authenticated user.
        /// </summary>
        public BaseUser AuthenticatedUser { get; set; }

        /// <summary>
        /// Creates a new <see cref="APIRequest"/> instance.
        /// </summary>
        public APIRequest()
        {
            Headers = new NancyRequestHeaders();
            QueryString = new Dictionary<string, string>();
        }
    }
}
