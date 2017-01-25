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
using System.Collections.Generic;

using Limitless.Runtime.Types;

namespace Limitless.Runtime.Interactions
{
    /// <summary>
    /// Holds the information for a matched skill
    /// from an intent that can be actioned by the
    /// interaction engine.
    /// </summary>
    public class Actionable
    {
        /// <summary>
        /// Gets the matched skill.
        /// </summary>
        public Skill Skill { get; set; }
        /// <summary>
        /// Extracted parameters from the input including
        /// required parameters. See <see cref="Skill.Parameters"/>
        /// </summary>
        public Dictionary<string, object> SkillParameters { get; set; }
        /// <summary>
        /// Gets the confidence when matched.
        /// </summary>
        public int Confidence { get; set; }

        /// <summary>
        /// Standard constructor.
        /// </summary>
        public Actionable()
        {
            SkillParameters = new Dictionary<string, object>();
            Confidence = 0;
        }

        /// <summary>
        /// Constructor setting the skill.
        /// </summary>
        /// <param name="skill">The matched skill</param>
        public Actionable(Skill skill)
        {
            Skill = skill;
            SkillParameters = new Dictionary<string, object>();
            Confidence = 0;
        }
        
        /// <summary>
        /// Constructor setting the matched skill,
        /// and confidence in the match.
        /// </summary>
        /// <param name="skill">The matched skill</param>
        /// <param name="confidence">The confidence of the match</param>
        public Actionable(Skill skill, int confidence)
        {
            Skill = skill;
            SkillParameters = new Dictionary<string, object>();
            Confidence = confidence;
        }

        /// <summary>
        /// Checks if all the required parameters for
        /// a <see cref="Skill"/> has been extracted into
        /// SkillParameters.
        /// </summary>
        /// <returns>Returns true if a required parameter is missing, false otherwise</returns>
        public bool HasMissingParameters()
        {
            foreach (SkillParameter parameter in this.Skill.Parameters)
            {
                if (this.SkillParameters.ContainsKey(parameter.Parameter) == false && parameter.IsRequired)
                {
                    return true;
                }
            }
            return false;
        }
         
        /// <summary>
        /// Returns the list of the missing required parameters
        /// for a matched skill.
        /// </summary>
        /// <returns>The list of missing required parameters</returns>
        public List<SkillParameter> GetMissingParameters()
        {
            List<SkillParameter> missingParameters = new List<SkillParameter>();
            foreach (SkillParameter parameter in this.Skill.Parameters)
            {
                if (this.SkillParameters.ContainsKey(parameter.Parameter) == false && parameter.IsRequired)
                {
                    missingParameters.Add(parameter);
                }
            }
            return missingParameters;
        }

        /// <summary>
        /// Gets a list of parameters of a specific type.
        /// </summary>
        /// <param name="type">The <see cref="Limitless.Runtime.Enums.SkillParameterType"/></param>
        /// <returns>The list of parameters matching the given type</returns>
        public List<SkillParameter> GetParametersByType(string type)
        {
            List<SkillParameter> parameters = new List<SkillParameter>();
            foreach (SkillParameter parameter in this.Skill.Parameters)
            {
                if (parameter.Type == type)
                {
                    parameters.Add(parameter);
                }
            }
            return parameters;
        }
    }
}
