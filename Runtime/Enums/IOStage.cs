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
    /// Defines if a given IOProcessor should be
    /// executed before or after the interaction engine.
    /// </summary>
    public enum IOStage
    {
        /// <summary>
        /// Executed before the interaction engine.
        /// </summary>
        PreProcessor,
        /// <summary>
        /// Executed after the interaction engine.
        /// </summary>
        PostProcessor
    }
}