﻿/** 
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

using System;

namespace Limitless.Runtime.Interactions
{
    /// <summary>
    /// A skill executor that runs over HTTP/HTTPS.
    /// </summary>
    public class NetworkExecutor
    {
        /// <summary>
        /// The full URL endpoint to execute against.
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// Should the certificate be validated for HTTPS calls. 
        /// Defaults to true;
        /// </summary>
        public bool ValidateCertificate { get; set; } = true;
    }
}
