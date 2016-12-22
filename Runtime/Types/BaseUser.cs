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
using System.Security.Principal;

namespace Limitless.Runtime.Types
{
    /// <summary>
    /// Defines the base user object.
    /// </summary>
    public class BaseUser : IIdentity
    {
        /// <summary>
        /// Gets and sets the user's first name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Gets the authentication type used.
        /// </summary>
        public string AuthenticationType { get; private set; }
        /// <summary>
        /// Gets the authentication state of the user.
        /// </summary>
        public bool IsAuthenticated { get; private set; }
        /// <summary>
        /// Gets and sets the user's surname
        /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// The username, usually an email address.
        /// </summary>
        public string Username { get; private set; }
        /// <summary>
        /// The user's access token.
        /// </summary>
        public string AccessToken { get; set; }

        /// <summary>
        /// Constructor setting the username and authentication state.
        /// </summary>
        /// <param name="username">The username to set</param>
        public BaseUser(string username, bool isAuthenticated)
        {
            // Token authentication is currently the default
            AuthenticationType = "token";
            Username = username;
            IsAuthenticated = isAuthenticated;
        }
    }
}
