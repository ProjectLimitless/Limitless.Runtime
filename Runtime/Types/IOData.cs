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
    /// Holds data for Input handlers input and outputs.
    /// </summary>
    public class IOData
    {
        /// <summary>
        /// The Mime and Language for Data.
        /// </summary>
        public MimeLanguage MimeLanguage { get; set; }
        /// <summary>
        /// The data of type Mime.
        /// </summary>
        public dynamic Data { get; set; }

        /// <summary>
        /// Standard constructor with given MIME/Language.
        /// </summary>
        /// <param name="mimeLanguage">The MIME/Language combination of the Data</param>
        public IOData(MimeLanguage mimeLanguage)
        {
            MimeLanguage = mimeLanguage;
        }

        /// <summary>
        /// Standard constructor with given MIME/Language and Data.
        /// </summary>
        /// <param name="mimeLanguage">The MIME/Language combination of the Data</param>
        /// <param name="data">The data</param>
        public IOData(MimeLanguage mimeLanguage, dynamic data)
        {
            MimeLanguage = mimeLanguage;
            Data = data;
        }
    }
}
