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
        /// Logs in a user with an already issued token and returns the result
        /// containing an error of the user object and access token.
        /// </summary>
        /// <param name="token">The token to log in with</param>
        /// <returns>The result of the token login attempt</returns>
        LoginResult TokenLogin(string token);
        /// <summary>
        /// Log a user in using the provided username and password and returns
        /// a login result containing an error or the user object and
        /// access token.
        /// </summary>
        /// <param name="username">The user's username</param>
        /// <param name="password">The user's password</param>
        /// <returns>The result of the login attempt</returns>
        LoginResult Login(string username, string password);
        /*
        Create
        View
        Update
        Delete
        */
    }
}
