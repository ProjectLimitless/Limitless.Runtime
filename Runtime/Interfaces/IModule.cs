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

using System;

namespace Limitless.Runtime.Interfaces
{
    /// <summary>
    /// The interface required to be implemented by all modules
    /// that should be loadable by Project Limitless.
    /// </summary>
    public interface IModule
    {
        /// <summary>
        /// Configure the instance using settings of type GetConfigurationType().
        /// </summary>
        /// <param name="settings">The settings to configure the instance with</param>
        void Configure(dynamic settings);
        /// <summary>
        /// Returns the type of configuration object used by the module.
        /// </summary>
        /// <returns>The type of the configuration</returns>
        Type GetConfigurationType();
    }
}
