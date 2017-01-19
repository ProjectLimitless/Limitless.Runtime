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
    /// Holds parameters required to execute a skill.
    /// </summary>
    public class SkillRequiredParameter
    {
        /// <summary>
        /// The parameter to search for.
        /// </summary>
        public string Parameter { get; set; }
        /// <summary>
        /// The type of data expected.
        /// See <see cref="Limitless.Runtime.Enums.SkillParameterType"/> 
        /// for available types.
        /// </summary>
        public string Type { get; set; }
    }
}
