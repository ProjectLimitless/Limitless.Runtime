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

using Limitless.Runtime.Interfaces;

namespace Limitless.Runtime.Interactions
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
        /// The unique ID of the skill.
        /// Should be less than 128 characters.
        /// </summary>
        public string UUID { get; set; }
        /// <summary>
        /// The name of the skill.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The location where the skill is executed.
        /// </summary>
        public string Location { get; set; }
        /// <summary>
        /// The intent that will trigger this skill.
        /// </summary>
        public Intent Intent { get; set; }
        /// <summary>
        /// The <see cref="Limitless.Runtime.Enums.SkillExecutorBinding"/> of
        /// the Executor.
        /// </summary>
        public string Binding { get; set; }
        /// <summary>
        /// Defines the method for executing the skill.
        /// </summary>
        public dynamic Executor { get; set; }

        /// <summary>
        /// Default constructor. Sets a default Guid UUID.
        /// </summary>
        public Skill()
        {
            UUID = Guid.NewGuid().ToString();
        }
    }
}
