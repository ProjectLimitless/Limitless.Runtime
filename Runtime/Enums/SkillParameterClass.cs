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
    /// Skill parameter classes determine how the values will be 
    /// extracted from the given input.
    /// </summary>
    public static class SkillParameterClass
    {
        /// <summary>
        /// An integer value should be extracted. 
        /// </summary>
        public const string IntegerValue = "value-integer";
        /// <summary>
        /// A quantity should be extracted. Examples like 
        /// 'a little bit of', 'just a bit', etc.
        /// </summary>
        public const string Quantity = "quantity";
        /// <summary>
        /// Dates with time should be extracted.
        /// </summary>
        public const string DateRange = "date-range";
        /// <summary>
        /// Locations should be extracted.
        /// </summary>
        public const string Location = "location";
    }
}