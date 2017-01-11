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
    /// Defines the default MIME types for Project Limitless.
    /// </summary>
    public static class MimeType
    {
        /// <summary>
        /// JSON data.
        /// application/json
        /// </summary>
        public static string Json { get { return "application/json"; } }
        /// <summary>
        /// Wave data.
        /// audio/wav
        /// </summary>
        public static string Wav { get { return "audio/wav"; } }
        /// <summary>
        /// Plain text data.
        /// text/plain
        /// </summary>
        public static string Text { get { return "text/plain"; } }
    }
}