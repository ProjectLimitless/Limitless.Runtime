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

using Limitless.Runtime.Types;

namespace Limitless.Runtime.Interfaces
{
    /// <summary>
    /// The interface required to be implemented by modules providing
    /// the user management, authentication, and authorization.
    /// </summary>
    public interface IIdentityProvider
    {
        /// <summary>
        /// Validates an already issued token and returns the user if valid, null otherwise. 
        /// </summary>
        /// <param name="token">The token to validate</param>
        /// <returns>The user object if logged in and valid, null otherwise</returns>
        BaseUser ValidateToken(string token);
        /// <summary>
        /// Log a user in using the provided username and password and returns
        /// the user object containing the access token if successful.
        /// </summary>
        /// <param name="username">The user's username</param>
        /// <param name="password">The user's password</param>
        /// <exception cref="UnauthorizedAccessException">Thrown is login fails</exception>
        /// <exception cref="MissingFieldException">Thrown if username of password is blank</exception>
        /// <returns>The user object if logged in, null otherwise</returns>
        BaseUser Login(string username, string password);
        /*
        Create
        View
        Update
        Delete
        */
    }
}
