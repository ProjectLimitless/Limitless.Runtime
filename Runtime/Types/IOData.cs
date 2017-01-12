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
    /// Holds data for Input handlers input and outputs.
    /// </summary>
    public class IOData
    {
        /// <summary>
        /// The MIME type of the Data.
        /// </summary>
        public string Mime { get; set; }
        /// <summary>
        /// The data of type Mime.
        /// </summary>
        public dynamic Data { get; set; }

        /// <summary>
        /// Standard constructor with given MIME type.
        /// </summary>
        /// <param name="mime">The MIME type of the Data</param>
        public IOData(string mime)
        {
            Mime = mime;
        }

        /// <summary>
        /// Standard constructor with MIME type for the Data.
        /// </summary>
        /// <param name="mime">The MIME type of the Data</param>
        /// <param name="data">The data</param>
        public IOData(string mime, dynamic data)
        {
            Mime = mime;
            Data = data;
        }
    }
}
