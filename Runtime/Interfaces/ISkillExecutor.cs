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
using System.Collections.Generic;

using Limitless.Runtime.Types;

namespace Limitless.Runtime.Interfaces
{
    /// <summary>
    /// Defines the method of executing a skill.
    /// </summary>
    public interface ISkillExecutor
    {
        /// <summary>
        /// Execute the given skill.
        /// 
        /// // TODO: Rethink - see Skill.cs
        /// </summary>
        /// <param name="skill"></param>
        void ExecuteSkill(Skill skill);
    }
}
