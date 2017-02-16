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
using System.IO;
using System.Text;
using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

using Limitless.Runtime.Enums;
using Limitless.Runtime.Types;
using Limitless.Runtime.Interfaces;

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
		/// TODO: This is not always set from Swagger API calls
        public bool ValidateCertificate { get; set; } = true;

        /// <summary>
        /// Implemented from interface
        /// <see cref="Limitless.Runtime.Interfaces.ISkillExecutor.Execute(Actionable)"/>
        /// </summary>
        public ActionableResult Execute(Actionable actionable)
        {
            var networkExecutorPayload = new NetworkExecutorPayload
            {
                SkillUUID = actionable.Skill.UUID,
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
            string payload = Encoding.UTF8.GetString(rawPayload, 0, rawPayload.Length);
            
            Console.WriteLine(payload);
            // Submit the matched skill with parameters to the network skill
            var requestHandler = new WebRequestHandler();
            if (ValidateCertificate == false)
            {
                // TODO: Check that this actually works
                // Validation is turned off, most likely for self-signed certificates.
                // Accept all the certificates!
                requestHandler.ServerCertificateValidationCallback += (sender, certificate, chain, policyErrors) => true;
            }
            var actionableResult = new ActionableResult();
            using (var client = new HttpClient(requestHandler))
            {
                var response = client.PostAsync(Url, new StringContent(payload, Encoding.UTF8, MimeType.Json));
                if (!response.Result.IsSuccessStatusCode)
                {
                    throw new HttpRequestException(
                        $"Error received from Network skill '{actionable.Skill.UUID} ({actionable.Skill.Name})'. Code {response.Result.StatusCode}");
                }
                // TODO: Expand to more media types - not just string
                actionableResult.Data = response.Result.Content.ReadAsStringAsync().Result;
                actionableResult.ContentType = response.Result.Content.Headers.ContentType.MediaType;
                actionableResult.ContentLanguage = response.Result.Content.Headers.ContentLanguage.First();
            }
            return actionableResult;
        }
    }
}
