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
using System.Collections.Generic;

using Limitless.Runtime.Types;
using Limitless.Runtime.Enums;

namespace Limitless.Runtime.Interfaces
{
    /// <summary>
    /// The interface required to be implemented by modules 
    /// that form part of the input/output pipelines.
    /// </summary>
    public interface IIOProvider
    {
        /// <summary>
        /// Get and sets the direction of the input/output provider.
        /// </summary>
        IODirection Direction { get; set; }
        /// <summary>
        /// Gets the list of MIME types this provider can handle.
        /// </summary>
        /// <returns>The MIME types handled by this provider</returns>
        IEnumerable<MimeLanguageCombination> GetSupportedMimeLanguages();
        /// TODO: Determine input and output types?
        /// <summary>
        /// Process the given data.
        /// </summary>
        /// <param name="data">The data object to process</param>
        /// <returns>The result of processing the data</returns>
        IOData Process(IOData data);
    }
}