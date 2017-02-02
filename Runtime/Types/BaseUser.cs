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

using System.Collections.Generic;

namespace Limitless.Runtime.Types
{
    /// <summary>
    /// Defines the base user object.
    /// </summary>
    public class BaseUser
    {
        /// <summary>
        /// An enumerable containing the allowed claims for
        /// an authenticated user.
        /// </summary>
        public IEnumerable<string> Claims { get; internal set; }
        /// <summary>
        /// The username, usually an email address.
        /// </summary>
        public string UserName { get; internal set; }
        /// <summary>
        /// Gets and sets the user's first name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Gets and sets the user's surname
        /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// The user's access token.
        /// </summary>
        public string AccessToken { get; set; }
        /// <summary>
        /// Returns true is the user is authenticated.
        /// </summary>
        public bool IsAuthenticated { get; internal set; }

        /// <summary>
        /// Create a new instance of <see cref="BaseUser"/>
        /// setting the username.
        /// </summary>
        /// <param name="username">The username to set</param>
        public BaseUser(string username)
        {
            UserName = username;
            Claims = new List<string>();
        }

        /// <summary>
        /// Create a new instance of <see cref="BaseUser"/>
        /// setting the username and is the user is authenticated.
        /// </summary>
        /// <param name="username">The username to set</param>
        /// <param name="isAuthenticated">The authentication state of the user</param>
        public BaseUser(string username, bool isAuthenticated)
        {
            UserName = username;
            IsAuthenticated = isAuthenticated;
            Claims = new List<string>();
        }
    }
}
