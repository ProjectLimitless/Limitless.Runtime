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
    /// Holds parameters for a skill.
    /// </summary>
    public class SkillParameter
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
        /// <summary>
        /// Is this parameter required or optional. Default to true.
        /// </summary>
        public bool IsRequired { get; set; }

        /// <summary>
        /// Creates a new instance of <see cref="SkillParameter"/>.
        /// </summary>
        public SkillParameter()
        {   
            // The default constructor is needed for serialization
        }

        /// <summary>
        /// Creates a new instance of <see cref="SkillParameter"/> setting
        /// the parameter and type.
        /// </summary>
        /// <param name="parameter">The name of the parameter</param>
        /// <param name="type">The type of the parameter. See <see cref="Limitless.Runtime.Enums.SkillParameterType"/></param>
        public SkillParameter(string parameter, string type)
        {
            Parameter = parameter;
            Type = type;
            IsRequired = true;
        }

        /// <summary>
        /// Creates a new instance of <see cref="SkillParameter"/> setting
        /// the parameter, type and if it is required.
        /// </summary>
        /// <param name="parameter">The name of the parameter</param>
        /// <param name="type">The type of the parameter. See <see cref="Limitless.Runtime.Enums.SkillParameterType"/></param>
        /// <param name="isRequired">Is this parameter required or optional</param>
        public SkillParameter(string parameter, string type, bool isRequired)
        {
            Parameter = parameter;
            Type = type;
            IsRequired = isRequired;
        }
    }
}
