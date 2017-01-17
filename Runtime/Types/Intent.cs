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
    /// Defines an intent. 
    /// // TODO: Maybe /interaction-engine/intents?
    /// See https://docs.projectlimitless.io/project-limitless/intents.
    /// </summary>
    public class Intent
    {
        /// <summary>
        /// The intent action. Defaults to a blank string.
        /// </summary>
        public string Action { get; set; }
        /// <summary>
        /// The target of the action, if available. Defaults to a blank string.
        /// </summary>
        public string Target { get; set; }
        /// <summary>
        /// The date range of the intent, if available.
        /// </summary>
        public DateRange Date { get; set; }

        /// <summary>
        /// Standard constructor setting defaults.
        /// </summary>
        public Intent()
        {
            Action = "";
            Target = "";
        }
    }
}
