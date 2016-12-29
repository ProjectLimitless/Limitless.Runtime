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

namespace Limitless.Runtime.Enums
{
    /// <summary>
    /// Defines the available Http methods for extending the API.
    /// 
    /// The standard .NET System.Net.Http.HttpMethod cannot be used
    /// in a custom attribute which is why I define my own.
    /// </summary>
    public enum HttpMethod
    {
        /// <summary>
        /// GET HTTP Method
        /// </summary>
        Get,
        /// <summary>
        /// POST HTTP Method
        /// </summary>
        Post,
        /// <summary>
        /// PUT HTTP Method
        /// </summary>
        Put,
        /// <summary>
        /// DELETE HTTP Method
        /// </summary>
        Delete,
        /// <summary>
        /// HEAD HTTP Method
        /// </summary>
        Head,
        /// <summary>
        /// OPTIONS HTTP Method
        /// </summary>
        Options
    }
}