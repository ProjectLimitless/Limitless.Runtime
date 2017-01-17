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
    /// Defines the available logging level that must
    /// be supported by ILoggers.
    /// </summary>
    public enum LogLevel
    {
        /// <summary>
        /// Trace messages are used when more detail than debug is required.
        /// </summary>
        Trace,
        /// <summary>
        /// Debug messages are output enought information required
        /// to solve uncommon problems.
        /// </summary>
        Debug,
        /// <summary>
        /// Info messages are output enough information to see
        /// what the system is busy doing.
        /// </summary>
        Info,
        /// <summary>
        /// Warning messages are be written when a problem should
        /// be noted, but doesn't have a major impact.
        /// </summary>
        Warning,
        /// <summary>
        /// Error messages are written when a problem
        /// influences the execution of the system.
        /// </summary>
        Error,
        /// <summary>
        /// Critical errors are written when system critical
        /// errors occur. The system will usually exit after this.
        /// </summary>
        Critical
    }
}