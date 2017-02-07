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
using System.IO;
using System.Runtime.Serialization;
using Limitless.Runtime.Interfaces;
using System.Runtime.Serialization.Json;
using Limitless.Runtime.Enums;
using Limitless.Runtime.Types;

namespace Limitless.Runtime.Interactions
{
    /// <summary>
    /// A skill executor that runs over HTTP/HTTPS.
    /// </summary>
    public class NetworkExecutor : ISkillExecutor
    {
        /// <summary>
        /// The full URL endpoint to execute against.
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// Should the certificate be validated for HTTPS calls. 
        /// Defaults to true;
        /// </summary>
        public bool ValidateCertificate { get; set; } = true;

        /// <summary>
        /// Implemented from interface
        /// <see cref="Limitless.Runtime.Interfaces.ISkillExecutor.Execute(Actionable)"/>
        /// </summary>
        public void Execute(Actionable actionable)
        {
            Console.WriteLine($"EXECUUUUUTE to {Url} - {actionable.Skill.Name}!");

            var networkExecutorPayload = new NetworkExecutorPayload
            {
                Skill = actionable.Skill,
                SkillParameters = actionable.SkillParameters
            };
            var ms = new MemoryStream();
            var serializer = new DataContractJsonSerializer(typeof(NetworkExecutorPayload),
                new DataContractJsonSerializerSettings
                {
                    // TODO: Read from the SkillParameterTypes!!
                    KnownTypes = new List<Type>() { typeof(DateRange) },
                    DateTimeFormat = new DateTimeFormat("yyyy-MM-ddTHH:mm:ss.fffzzz"),
                });
            serializer.WriteObject(ms, networkExecutorPayload);
            byte[] rawPayload = ms.ToArray();
            ms.Close();
            string payload = System.Text.Encoding.UTF8.GetString(rawPayload, 0, rawPayload.Length);

            // Calculate the signature of the payload based on the initial
            // skill's temporary private key
            if (actionable.Skill.PrivateKey != "")
            {   
                Console.WriteLine("SIIIIGN!");

                if (ValidateCertificate)
                {
                    // TODO: Check?
                }
            }

            // Submit the matched skill with parameters to the network skill

        }
    }
}
