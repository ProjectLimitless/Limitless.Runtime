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

using Limitless.Runtime.Interactions;

namespace Limitless.Runtime.Interfaces
{
    /// <summary>
    /// The interface required to be implemented by modules providing
    /// the primary interaction engine. The interaction engine
    /// handles almost all interaction with Project Limitless.
    /// </summary>
    public interface ISkillExecutor
    {
        /// <summary>
        /// Execute the given actionable.
        /// </summary>
        /// <param name="actionable">The actionable to execute</param>
        void Execute(Actionable actionable);
    }
}
