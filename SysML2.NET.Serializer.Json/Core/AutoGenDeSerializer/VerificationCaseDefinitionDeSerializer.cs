﻿// -------------------------------------------------------------------------------------------------
// <copyright file="VerificationCaseDefinitionDeSerializer.cs" company="RHEA System S.A.">
//
//   Copyright 2022-2023 RHEA System S.A.
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//        http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
//
// </copyright>
// ------------------------------------------------------------------------------------------------

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------

namespace SysML2.NET.Core.DTO.Serializer.Json
{
    using System;
    using System.Text.Json;

    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Logging.Abstractions;

    using SysML2.NET.Common;
    using SysML2.NET.Core.DTO;

    using SysML2.NET.Serializer.Json;

    /// <summary>
    /// The purpose of the <see cref="VerificationCaseDefinitionDeSerializer"/> is to provide deserialization capabilities
    /// for the <see cref="IVerificationCaseDefinition"/> interface
    /// </summary>
    internal static class VerificationCaseDefinitionDeSerializer
    {
        /// <summary>
        /// Deserializes an instance of <see cref="IVerificationCaseDefinition"/> from the provided <see cref="JsonElement"/>
        /// </summary>
        /// <param name="jsonElement">
        /// The <see cref="JsonElement"/> that contains the <see cref="IVerificationCaseDefinition"/> json object
        /// </param>
        /// <param name="serializationModeKind">
        /// enumeration specifying what kind of serialization shall be used
        /// </param>
        /// <param name="loggerFactory">
        /// The <see cref="ILoggerFactory"/> used to setup logging
        /// </param>
        /// <returns>
        /// an instance of <see cref="IVerificationCaseDefinition"/>
        /// </returns>
        internal static IVerificationCaseDefinition DeSerialize(JsonElement jsonElement, SerializationModeKind serializationModeKind, ILoggerFactory loggerFactory = null)
        {
            var logger = loggerFactory == null ? NullLogger.Instance : loggerFactory.CreateLogger("VerificationCaseDefinitionDeSerializer");

            if (!jsonElement.TryGetProperty("@type"u8, out JsonElement @type))
            {
                throw new InvalidOperationException("The @type property is not available, the VerificationCaseDefinitionDeSerializer cannot be used to deserialize this JsonElement");
            }

            if (@type.GetString() != "VerificationCaseDefinition")
            {
                throw new InvalidOperationException($"The VerificationCaseDefinitionDeSerializer can only be used to deserialize objects of type IVerificationCaseDefinition, a {@type.GetString()} was provided");
            }

            var dtoInstance = new Core.DTO.VerificationCaseDefinition();

            if (jsonElement.TryGetProperty("@id"u8, out JsonElement idProperty))
            {
                var propertyValue = idProperty.GetString();
                if (propertyValue == null)
                {
                    throw new JsonException("The @id property is not present, the VerificationCaseDefinition cannot be deserialized");
                }
                else
                {
                    dtoInstance.Id = Guid.Parse(propertyValue);
                }
            }

            if (jsonElement.TryGetProperty("aliasIds"u8, out JsonElement aliasIdsProperty))
            {
                foreach (var arrayItem in aliasIdsProperty.EnumerateArray())
                {
                    var propertyValue = arrayItem.GetString();
                    if (propertyValue != null)
                    {
                        dtoInstance.AliasIds.Add(propertyValue);
                    }
                }
            }
            else
            {
                logger.LogDebug($"the aliasIds Json property was not found in the VerificationCaseDefinition: {dtoInstance.Id}");
            }

            if (jsonElement.TryGetProperty("declaredName"u8, out JsonElement declaredNameProperty))
            {
                dtoInstance.DeclaredName = declaredNameProperty.GetString();
            }
            else
            {
                logger.LogDebug($"the declaredName Json property was not found in the VerificationCaseDefinition: {dtoInstance.Id}");
            }

            if (jsonElement.TryGetProperty("declaredShortName"u8, out JsonElement declaredShortNameProperty))
            {
                dtoInstance.DeclaredShortName = declaredShortNameProperty.GetString();
            }
            else
            {
                logger.LogDebug($"the declaredShortName Json property was not found in the VerificationCaseDefinition: {dtoInstance.Id}");
            }

            if (jsonElement.TryGetProperty("elementId"u8, out JsonElement elementIdProperty))
            {
                var propertyValue = elementIdProperty.GetString();
                if (propertyValue != null)
                {
                    dtoInstance.ElementId = propertyValue;
                }
            }
            else
            {
                logger.LogDebug($"the elementId Json property was not found in the VerificationCaseDefinition: {dtoInstance.Id}");
            }

            if (jsonElement.TryGetProperty("isAbstract"u8, out JsonElement isAbstractProperty))
            {
                if (isAbstractProperty.ValueKind != JsonValueKind.Null)
                {
                    dtoInstance.IsAbstract = isAbstractProperty.GetBoolean();
                }
            }
            else
            {
                logger.LogDebug($"the isAbstract Json property was not found in the VerificationCaseDefinition: {dtoInstance.Id}");
            }

            if (jsonElement.TryGetProperty("isImpliedIncluded"u8, out JsonElement isImpliedIncludedProperty))
            {
                if (isImpliedIncludedProperty.ValueKind != JsonValueKind.Null)
                {
                    dtoInstance.IsImpliedIncluded = isImpliedIncludedProperty.GetBoolean();
                }
            }
            else
            {
                logger.LogDebug($"the isImpliedIncluded Json property was not found in the VerificationCaseDefinition: {dtoInstance.Id}");
            }

            if (jsonElement.TryGetProperty("isIndividual"u8, out JsonElement isIndividualProperty))
            {
                if (isIndividualProperty.ValueKind != JsonValueKind.Null)
                {
                    dtoInstance.IsIndividual = isIndividualProperty.GetBoolean();
                }
            }
            else
            {
                logger.LogDebug($"the isIndividual Json property was not found in the VerificationCaseDefinition: {dtoInstance.Id}");
            }

            if (jsonElement.TryGetProperty("isSufficient"u8, out JsonElement isSufficientProperty))
            {
                if (isSufficientProperty.ValueKind != JsonValueKind.Null)
                {
                    dtoInstance.IsSufficient = isSufficientProperty.GetBoolean();
                }
            }
            else
            {
                logger.LogDebug($"the isSufficient Json property was not found in the VerificationCaseDefinition: {dtoInstance.Id}");
            }

            if (jsonElement.TryGetProperty("isVariation"u8, out JsonElement isVariationProperty))
            {
                if (isVariationProperty.ValueKind != JsonValueKind.Null)
                {
                    dtoInstance.IsVariation = isVariationProperty.GetBoolean();
                }
            }
            else
            {
                logger.LogDebug($"the isVariation Json property was not found in the VerificationCaseDefinition: {dtoInstance.Id}");
            }

            if (jsonElement.TryGetProperty("ownedRelationship"u8, out JsonElement ownedRelationshipProperty))
            {
                foreach (var arrayItem in ownedRelationshipProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id"u8, out JsonElement ownedRelationshipIdProperty))
                    {
                        var propertyValue = ownedRelationshipIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.OwnedRelationship.Add(Guid.Parse(propertyValue));
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the ownedRelationship Json property was not found in the VerificationCaseDefinition: {dtoInstance.Id}");
            }

            if (jsonElement.TryGetProperty("owningRelationship"u8, out JsonElement owningRelationshipProperty))
            {
                if (owningRelationshipProperty.ValueKind == JsonValueKind.Null)
                {
                    dtoInstance.OwningRelationship = null;
                }
                else
                {
                    if (owningRelationshipProperty.TryGetProperty("@id"u8, out JsonElement owningRelationshipIdProperty))
                    {
                        var propertyValue = owningRelationshipIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.OwningRelationship = Guid.Parse(propertyValue);
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the owningRelationship Json property was not found in the VerificationCaseDefinition: {dtoInstance.Id}");
            }


            return dtoInstance;
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
