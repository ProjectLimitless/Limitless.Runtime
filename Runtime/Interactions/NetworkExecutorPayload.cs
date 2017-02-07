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

namespace Limitless.Runtime.Interactions
{
    /// <summary>
    /// Holds all the data that should be sent to a
    /// network skill executor.
    /// </summary>
    public class NetworkExecutorPayload
    {
        /// <summary>
        /// The basic information of the matched skill.
        /// </summary>
        public Skill Skill { get; set; }
        /// <summary>
        /// The parameters extracted from the input for the given SKill.
        /// </summary>
        public Dictionary<string, object> SkillParameters { get; set; }
        /// <summary>
        /// The user information, if needed.
        /// </summary>
        public dynamic User { get; set; }
    }
}
