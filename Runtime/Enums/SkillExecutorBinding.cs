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

namespace Limitless.Runtime.Enums
{
    /// <summary>
    /// Defines the available skill executor binding methods.
    /// </summary>
    public static class SkillExecutorBinding
    {
        /// <summary>
        /// A type of executor that is executed over HTTP/HTTPS.
        /// </summary>
        public const string Network = "Network";
        /// <summary>
        /// A type of executor that is built in.
        /// </summary>
        public const string Builtin = "Builtin";
        /// <summary>
        /// A type of executor that was loaded as part of a module. 
        /// </summary>
        public const string Module = "Module";
    }
}