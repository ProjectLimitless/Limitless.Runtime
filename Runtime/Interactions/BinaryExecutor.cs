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

using System;

namespace Limitless.Runtime.Interactions
{
    /// <summary>
    /// A skill executor that is handled internally
    /// or by a loaded module.
    /// </summary>
    public class BinaryExecutor
    {
        /// <summary>
        /// The handling function taking a JSON string as
        /// input and returning a JSON string as output.
        /// // TODO: Is this documentation true?
        /// </summary>
        public Func<string, string> Handler;
    }
}
