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

using Limitless.Runtime.Enums;

namespace Limitless.Runtime.Interfaces
{
    /// <summary>
    /// The interface required to be implemented by modules providing
    /// input processing.
    /// </summary>
    public interface IInputProvider
    {
        /// TODO: Decide on properties vs methods for this.
        /// <summary>
        /// Gets the type of input the provider handles.
        /// </summary>
        /// <returns>The input type</returns>
        InputType GetInputType();
        /// TODO: Determine input and output types?
        /// <summary>
        /// Process the given input.
        /// </summary>
        /// <param name="input">The input object, can be audio, text, etc.</param>
        /// <returns>The result of processing the input</returns>
        dynamic Process(dynamic input);
    }
}
