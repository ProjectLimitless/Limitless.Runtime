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

namespace Limitless.Runtime.Types
{
    /// <summary>
    /// Defines a response from the IIdentityProvider's
    /// Login and TokenLogin methods.
    /// </summary>
    public class LoginResult
    {
        /// <summary>
        /// If true, login was a success. Failed otherwise.
        /// </summary>
        public bool IsAuthenticated { get; private set; }
        /// <summary>
        /// The user data when login succeeds.
        /// </summary>
        public BaseUser User { get; set; }
        /// <summary>
        /// The error response to return in case of 
        /// login failure.
        /// </summary>
        public string ErrorResponse { get; set; }

        /// <summary>
        /// Standard constructor specifying if login
        /// was a success or not.
        /// </summary>
        /// <param name="success">true if login was a success, false otherwise</param>
        public LoginResult(bool success)
        {
            IsAuthenticated = success;
            ErrorResponse = "";
            User = null;
        }

        /// <summary>
        /// Standard constructor specifying if login
        /// was a success or not as well as the error response if false.
        /// </summary>
        /// <param name="success">true if login was a success, false otherwise</param>
        /// <param name="errorResponse">The response to return if an error occurred</param>
        public LoginResult(bool success, string errorResponse)
        {
            if (success && string.IsNullOrEmpty(errorResponse) == false)
            {
                throw new NotSupportedException("You can't return an error response with a successful login");
            }
            IsAuthenticated = success;
            ErrorResponse = errorResponse;
            User = null;
        }

        /// <summary>
        /// Standard constructor specifying if login
        /// was a success or not as well as the user object.
        /// </summary>
        /// <param name="user">User data is login was a success</param>
        public LoginResult(BaseUser user)
        {
            if (user == null)
            {
                throw new NullReferenceException("User data can not be null");
            }
            ErrorResponse = "";
            IsAuthenticated = true;
            User = user;
        }
    }
}
