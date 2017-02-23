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

using System.Linq;
using System.Collections.Generic;

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
        /// required parameters. See <see cref="SkillParameter"/>
        /// </summary>
        public Dictionary<string, object> SkillParameters { get; set; }
        /// <summary>
        /// Parameters that should be queried, or asked, for.
        /// </summary>
        public List<SkillParameter> QueriedParameters { get; set; }
        /// <summary>
        /// The extracted location as registered by the skill.
        /// </summary>
        public string Location { get; set; }
        /// <summary>
        /// Gets the confidence when matched.
        /// </summary>
        public int Confidence { get; set; }

        /// <summary>
        /// Creates a new instance of <see cref="Actionable"/>
        /// </summary>
        public Actionable()
        {
            Confidence = 0;
            QueriedParameters = new List<SkillParameter>();
            SkillParameters = new Dictionary<string, object>();
        }

        /// <summary>
        /// Creates a new instance of <see cref="Actionable"/> with
        /// the skill set.
        /// </summary>
        /// <param name="skill">The matched skill</param>
        public Actionable(Skill skill)
        {
            Skill = skill;
            Confidence = 0;
            QueriedParameters = new List<SkillParameter>();
            SkillParameters = new Dictionary<string, object>();
        }

        /// <summary>
        /// Creates a new instance of <see cref="Actionable"/> setting 
        /// the matched skill and confidence in the match.
        /// </summary>
        /// <param name="skill">The matched skill</param>
        /// <param name="confidence">The confidence of the match</param>
        public Actionable(Skill skill, int confidence)
        {
            Skill = skill;
            Confidence = confidence;
            QueriedParameters = new List<SkillParameter>();
            SkillParameters = new Dictionary<string, object>();
        }

        /// <summary>
        /// Adds a new required parameter to the skill after
        /// registration.
        /// </summary>
        /// <param name="parameter">The <see cref="SkillParameter"/> to add</param>
        /// <returns>true if added, false otherwise</returns>
        public bool AddQueryParameter(SkillParameter parameter)
        {
            if (QueriedParameters.Any(x => x.Parameter == parameter.Parameter))
            {
                return false;
            }
            parameter.IsRequired = true;
            QueriedParameters.Insert(0, parameter);
            return true;
        }

        /// <summary>
        /// Checks if all the required parameters for
        /// a <see cref="Skill"/> has been extracted into
        /// SkillParameters.
        /// </summary>
        /// <returns>Returns true if a required parameter is missing, false otherwise</returns>
        public bool HasMissingParameters()
        {
            return 
                Skill.Parameters.Any(parameter => SkillParameters.ContainsKey(parameter.Parameter) == false && parameter.IsRequired) || 
                QueriedParameters.Any();
        }
         
        /// <summary>
        /// Returns the list of the missing required parameters
        /// for a matched skill.
        /// </summary>
        /// <returns>The list of missing required parameters</returns>
        public List<SkillParameter> GetMissingParameters()
        {
            var missingParameters = new List<SkillParameter>();
            missingParameters.AddRange(QueriedParameters);
            missingParameters.AddRange(Skill.Parameters.Where(parameter => SkillParameters.ContainsKey(parameter.Parameter) == false && parameter.IsRequired).ToList());
            return missingParameters;
        }

        /// <summary>
        /// Returns the list of dynamically added parameters.
        /// </summary>
        /// <returns>The list of parameters being queried</returns>
        public List<SkillParameter> GetQueriedParameters()
        {
            return QueriedParameters;
        }

        /// <summary>
        /// Gets a list of parameters of a specific type.
        /// </summary>
        /// <param name="classType">The <see cref="Limitless.Runtime.Enums.SkillParameterClass"/></param>
        /// <returns>The list of parameters matching the given type</returns>
        public List<SkillParameter> GetParametersByClass(string classType)
        {
            return Skill.Parameters.Where(parameter => parameter.ClassType == classType).ToList();
        }
    }
}
