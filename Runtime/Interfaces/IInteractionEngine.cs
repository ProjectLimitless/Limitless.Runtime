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

using Limitless.Runtime.Types;

namespace Limitless.Runtime.Interfaces
{
    /// <summary>
    /// The interface required to be implemented by modules providing
    /// the primary interaction engine. The interaction engine
    /// handles almost all interaction with Project Limitless.
    /// </summary>
    public interface IInteractionEngine
    {
        // Inputs
        /// <summary>
        /// Process input coming from the input
        /// pipeline and return the data to output via
        /// the output pipeline.
        /// </summary>
        /// <param name="ioData">The input data</param>
        /// <returns>The output data to send</returns>
        IOData ProcessInput(IOData ioData);
        
        // Skills
        void RegisterSkill();
        void DeregisterSkill();
        void ListSkills();

        // ExecuteSkill - Should be a function passed into the engine
        
    }
}
