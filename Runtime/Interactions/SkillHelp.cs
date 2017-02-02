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
    /// The help information for a skill.
    /// </summary>
    public class SkillHelp
    {
        /// <summary>
        /// The minimal phrase needed to execute the skill.
        /// </summary>
        public string Phrase { get; set; }
        /// <summary>
        /// An example phrase that would execute the skill.
        /// </summary>
        public string ExamplePhrase { get; set; }

        /// <summary>
        /// Creates a new instance of <see cref="SkillHelp"/> and
        /// sets the 'Not provided' defaults.
        /// </summary>
        public SkillHelp()
        {
            Phrase = "Not provided";
            ExamplePhrase = "Example not provided";
        }
    }
}
