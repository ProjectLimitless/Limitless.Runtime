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
    /// The allowed skill parameter types.
    /// </summary>
    public static class SkillParameterType
    {
        /// <summary>
        /// An integer larger of equal to zero.
        /// </summary>
        public const string Integer = "int";
        /// <summary>
        /// Dates with time.
        /// </summary>
        public const string DateRange = "date-range";
    }
}