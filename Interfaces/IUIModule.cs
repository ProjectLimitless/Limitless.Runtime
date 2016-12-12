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

namespace Limitless.Runtime
{
    /// <summary>
    /// The interface required to be implemented by all modules
    /// that define a user interface with static content routes.
    /// </summary>
    public interface IUIModule
    {
        /// <summary>
        /// Returns the path for the static content. Used as
        /// the URL route and folder.
        /// </summary>
        /// <returns>The folder and route</returns>
        string GetContentPath();
    }
}
