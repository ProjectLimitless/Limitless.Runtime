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
    /// Holds intent information after text input processing.
    /// TODO: Find a better name
    /// </summary>
    public class IOIntent
    {
        /// <summary>
        /// The name of the intent.
        /// </summary>
        public string Name { get; set; }
    }
}
