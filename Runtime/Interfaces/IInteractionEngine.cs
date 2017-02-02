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

using System.Collections.Generic;

using Limitless.Runtime.Types;
using Limitless.Runtime.Interactions;

namespace Limitless.Runtime.Interfaces
{
    /// <summary>
    /// The interface required to be implemented by modules providing
    /// the primary interaction engine. The interaction engine
    /// handles almost all interaction with Project Limitless.
    /// </summary>
    public interface IInteractionEngine
    {
        // Inputs
        /// <summary>
        /// Process input coming from the input
        /// pipeline and return the data to output via
        /// the output pipeline.
        /// </summary>
        /// <param name="ioData">The input data</param>
        /// <returns>The output data to send</returns>
        IOData ProcessInput(IOData ioData);
        /// <summary>
        /// Gets the supported combination of input/output MIME types
        /// and languages.
        /// </summary>
        /// <returns>The supported combinations</returns>
        IEnumerable<SupportedIOCombination> GetSupportedIOCombinations();

        /// <summary>
        /// Register a new skill.
        /// </summary>
        /// <param name="skill">The skill to register</param>
        /// <returns>true if the skill is registered, false otherwise</returns>
        bool RegisterSkill(Skill skill);
        /// <summary>
        /// Deregister a registered skill.
        /// </summary>
        /// <param name="skillUuid">The skill's UUID to deregister</param>
        /// <returns>true if deregistered, false otherwise</returns>
        bool DeregisterSkill(string skillUuid);
        /// <summary>
        /// Get a list of registered skills.
        /// </summary>
        /// <returns></returns>
        List<Skill> ListSkills();
    }
}
