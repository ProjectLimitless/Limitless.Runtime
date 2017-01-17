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

namespace Limitless.Runtime.Types
{
    /// <summary>
    /// Defines a skill. 
    /// // TODO: Maybe /interaction-engine/skills?
    /// See https://docs.projectlimitless.io/project-limitless/skills.
    /// </summary>
    public class Skill
    {
        // TODO: Find way to set values only once
        // TODO: Where should required data be?

        /// <summary>
        /// The name of the skill.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The intent that will trigger this skill.
        /// </summary>
        public Intent Intent { get; set; }
        /// <summary>
        /// Defines the method for executing the skill. Currently only
        /// the NetworkSkillExecutor is available.
        /// //TODO: Rethink this. Skill.Executor.Execute(skill) doesn't make sense.
        /// </summary>
        public ISkillExecutor Executor { get; set; }
    }
}
