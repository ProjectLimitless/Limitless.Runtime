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

using Limitless.Runtime.Interfaces;

namespace Limitless.Runtime.Interactions
{
    /// <summary>
    /// Holds the result of the executed
    /// <see cref="Actionable"/> by an <see cref="ISkillExecutor"/>
    /// </summary>
    public class ActionableResult
    {
        /// <summary>
        /// The <see cref="Actionable"/> that this is
        /// a result for.
        /// </summary>
        public Actionable Actionable { get; set; }
        /// <summary>
        /// The Content-Type of the Data.
        /// </summary>
        public string ContentType { get; set; }
        /// <summary>
        /// The language of the Data.
        /// </summary>
        public string ContentLanguage { get; set; }
        /// <summary>
        /// The result data.
        /// </summary>
        public object Data { get; set; }
    }
}
