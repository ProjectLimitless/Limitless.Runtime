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

namespace Limitless.Runtime.Types
{
    /// <summary>
    /// Holds the MIME and Language for input
    /// and output support.
    /// </summary>
    public class SupportedIOCombination
    {
        /// <summary>
        /// The Mime/Language combination for supported input.
        /// </summary>
        public MimeLanguage SupportedInput { get; set; }
        /// <summary>
        /// The Mime/Language combination for supported output.
        /// </summary>
        public MimeLanguage SupportedOutput { get; set; }
        
        /// <summary>
        /// Creates a new <see cref="SupportedIOCombination"/>
        /// and initializes the <see cref="SupportedInput"/> and
        /// <see cref="SupportedOutput"/> properties.
        /// </summary>
        public SupportedIOCombination()
        {
            SupportedInput = new MimeLanguage();
            SupportedOutput = new MimeLanguage();
        }

        /// <summary>
        /// Creates a new <see cref="SupportedIOCombination"/> setting 
        /// the supported input combination and initializes the
        /// <see cref="SupportedOutput"/> property.
        /// </summary>
        /// <param name="supportedInput">The supported input combination</param>
        public SupportedIOCombination(MimeLanguage supportedInput)
        {
            SupportedInput = supportedInput;
            SupportedOutput = new MimeLanguage();
        }

        /// <summary>
        /// Creates a new <see cref="SupportedIOCombination"/> setting the 
        /// supported input and output combinations.
        /// </summary>
        /// <param name="supportedInput">The supported input combination</param>
        /// <param name="supportedOutput">The supported ouput combination</param>
        public SupportedIOCombination(MimeLanguage supportedInput, MimeLanguage supportedOutput)
        {
            SupportedInput = supportedInput;
            SupportedOutput = supportedOutput;
        }
    }
}
