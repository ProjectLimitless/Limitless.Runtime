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

namespace Limitless.Runtime.Interfaces
{
    /// <summary>
    /// The interface required to be implemented by all modules
    /// that provide logging.
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Update the logging level.
        /// </summary>
        /// <param name="level">The level to update to</param>
        void UpdateLevel(string level);
        /// <summary>
        /// Trace messages should be used when debug isn't enough.
        /// </summary>
        /// <param name="format">The format of the string</param>
        /// <param name="args">The parameters to format</param>
        void Trace(string format, params object[] args);
        /// <summary>
        /// Debug messages should output enought information required
        /// to solve uncommon problems.
        /// </summary>
        /// <param name="format">The format of the string</param>
        /// <param name="args">The parameters to format</param>
        void Debug(string format, params object[] args);
        /// <summary>
        /// Info messages should output enough information to see
        /// what the system is busy doing.
        /// </summary>
        /// <param name="format">The format of the string</param>
        /// <param name="args">The parameters to format</param>
        void Info(string format, params object[] args);
        /// <summary>
        /// Warning messages should be written when a problem should
        /// be noted, but doesn't have a major impact.
        /// </summary>
        /// <param name="format">The format of the string</param>
        /// <param name="args">The parameters to format</param>
        void Warning(string format, params object[] args);
        /// <summary>
        /// Error messages need to be written when a problem
        /// influences the execution of the system.
        /// </summary>
        /// <param name="format">The format of the string</param>
        /// <param name="args">The parameters to format</param>
        void Error(string format, params object[] args);
        /// <summary>
        /// Critical errors must be written when system critical
        /// errors occur. The system will usually exit after this.
        /// </summary>
        /// <param name="format">The format of the string</param>
        /// <param name="args">The parameters to format</param>
        void Critical(string format, params object[] args);
    }
}
