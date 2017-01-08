/** 
* This file is part of Project Limitless.
* Copyright © 2016 Donovan Solms.
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
    /// Defines the available input types for Project Limitless.
    /// </summary>
    public enum InputType
    {
        /// <summary>
        /// Plain text input.
        /// </summary>
        Text,
        /// <summary>
        /// Audio input.
        /// </summary>
        Audio,
        /// <summary>
        /// Image input.
        /// </summary>
        Image,
        /// <summary>
        /// Streaming video input.
        /// </summary>
        Video
    }
}