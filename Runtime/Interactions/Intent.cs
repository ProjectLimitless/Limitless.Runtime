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
    /// Defines an intent. 
    /// // TODO: Maybe /interaction-engine/intents?
    /// See https://docs.projectlimitless.io/project-limitless/intents.
    /// </summary>
    public class Intent
    {
        /// <summary>
        /// The intent actions.
        /// </summary>
        public List<string> Actions { get; set; }
        /// <summary>
        /// The targets of the actions, if available.
        /// </summary>
        public List<string> Targets { get; set; }
        
        /// <summary>
        /// Standard constructor setting defaults.
        /// </summary>
        public Intent()
        {
            Actions = new List<string>();
            Targets = new List<string>();
        }
    }
}
