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

using System;

using Limitless.Runtime.Enums;

namespace Limitless.Runtime.Types
{
    /// <summary>
    /// Holds the MIME and Language for input
    /// and output routing.
    /// </summary>
    public class MimeLanguageCombination
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
        /// Standard constructor.
        /// </summary>
        public MimeLanguageCombination()
        {
            Mime = MimeType.Text;
            Language = "en";
        }

        /// <summary>
        /// Constructor setting MIME and Language.
        /// </summary>
        /// <param name="mime">The MIME type</param>
        /// <param name="language">The language</param>
        public MimeLanguageCombination(string mime, string language)
        {
            Mime = mime;
            Language = language;
        }
    }
}
