/** 
* This file is part of Project Limitless.
* Copyright © 2017 Donovan Solms.
* Project Limitless
* https://www.projectlimitless.io
* 
* Project Limitless is free software: you can redistribute it and/or modify
* it under the terms of the Apache License Version 2.0.
* 
* You should have received a copy of the Apache License Version 2.0 with
* Project Limitless. If not, see http://www.apache.org/licenses/LICENSE-2.0.
*/

using Limitless.Runtime.Enums;

namespace Limitless.Runtime.Types
{
    /// <summary>
    /// Holder for Mime and Language combination.
    /// </summary>
    public class MimeLanguage
    {
        /// <summary>
        /// The Mime type.
        /// Defaults to text/plain.
        /// </summary>
        public string Mime { get; set; }
        /// <summary>
        /// The language tag. Should follow the 2 letter
        /// format with optional second 2 letter part  for location.
        /// Example en, en-us, en-za.
        /// See the HTTP definition at https://www.w3.org/Protocols/rfc2616/rfc2616-sec3.html#sec3.10
        /// Defaults to 'en'.
        /// </summary>
        public string Language { get; set; }
        
        /// <summary>
        /// Creates a new instance of <see cref="MimeLanguage"/>
        /// and sets the defaults.
        /// </summary>
        public MimeLanguage()
        {
            Mime = MimeType.Text;
            Language = "en";
        }

        /// <summary>
        /// Creates a new instance of <see cref="MimeLanguage"/>
        /// setting the provided MIME and Language.
        /// </summary>
        /// <param name="mime">The input MIME type</param>
        /// <param name="language">The input language</param>
        public MimeLanguage(string mime, string language)
        {
            Mime = mime;
            Language = language;
        }

        /// <summary>
        /// Returns the string represenation of MimeLanguage.
        /// </summary>
        /// <returns>The string representation</returns>
        public override string ToString()
        {
            return $"[MIME: {Mime}, Language: {Language}]";
        }
    }
}
