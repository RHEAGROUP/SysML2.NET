// -------------------------------------------------------------------------------------------------
// <copyright file="AnnotatingElementDeSerializer.cs" company="RHEA System S.A.">
//
//   Copyright 2022 RHEA System S.A.
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

namespace SysML2.NET.Serializer.Json
{
    using System;
    using System.Text.Json;

    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Logging.Abstractions;

    using SysML2.NET.Common;
    using SysML2.NET.Core.DTO;

    /// <summary>
    /// The purpose of the <see cref="AnnotatingElementDeSerializer"/> is to provide deserialization capabilities
    /// for the <see cref="IAnnotatingElement"/> interface
    /// </summary>
    internal static class AnnotatingElementDeSerializer
    {
        /// <summary>
        /// Deserializes an instance of <see cref="IAnnotatingElement"/> from the provided <see cref="JsonElement"/>
        /// </summary>
        /// <param name="jsonElement">
        /// The <see cref="JsonElement"/> that contains the <see cref="IAnnotatingElement"/> json object
        /// </param>
        /// <param name="serializationModeKind">
        /// enumeration specifying what kind of serialization shall be used
        /// </param>
        /// <param name="loggerFactory">
        /// The <see cref="ILoggerFactory"/> used to setup logging
        /// </param>
        /// <returns>
        /// an instance of <see cref="IAnnotatingElement"/>
        /// </returns>
        internal static IAnnotatingElement DeSerialize(JsonElement jsonElement, SerializationModeKind serializationModeKind, ILoggerFactory loggerFactory = null)
        {
            var logger = loggerFactory == null ? NullLogger.Instance : loggerFactory.CreateLogger("AnnotatingElementDeSerializer");

            if (!jsonElement.TryGetProperty("@type", out JsonElement @type))
            {
                throw new InvalidOperationException("The @type property is not available, the AnnotatingElementDeSerializer cannot be used to deserialize this JsonElement");
            }

            if (@type.GetString() != "AnnotatingElement")
            {
                throw new InvalidOperationException($"The AnnotatingElementDeSerializer can only be used to deserialize objects of type IAnnotatingElement, a {@type.GetString()} was provided");
            }

            var dtoInstance = new Core.DTO.AnnotatingElement();

            if (jsonElement.TryGetProperty("@id", out JsonElement idProperty))
            {
                var propertyValue = idProperty.GetString();
                if (propertyValue == null)
                {
                    throw new JsonException("The @id property is not present, the AnnotatingElement cannot be deserialized");
                }
                else
                {
                    dtoInstance.Id = Guid.Parse(propertyValue);
                }
            }

            if (jsonElement.TryGetProperty("aliasIds", out JsonElement aliasIdsProperty))
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
                logger.LogDebug($"the aliasIds Json property was not found in the AnnotatingElement: {dtoInstance.Id}");
            }

            if (jsonElement.TryGetProperty("annotation", out JsonElement annotationProperty))
            {
                foreach (var arrayItem in annotationProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id", out JsonElement annotationIdProperty))
                    {
                        var propertyValue = annotationIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.Annotation.Add(Guid.Parse(propertyValue));
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the annotation Json property was not found in the AnnotatingElement: {dtoInstance.Id}");
            }

            if (jsonElement.TryGetProperty("elementId", out JsonElement elementIdProperty))
            {
                var propertyValue = elementIdProperty.GetString();
                if (propertyValue != null)
                {
                    dtoInstance.ElementId = propertyValue;
                }
            }
            else
            {
                logger.LogDebug($"the elementId Json property was not found in the AnnotatingElement: {dtoInstance.Id}");
            }

            if (jsonElement.TryGetProperty("isImpliedIncluded", out JsonElement isImpliedIncludedProperty))
            {
                if (isImpliedIncludedProperty.ValueKind != JsonValueKind.Null)
                {
                    dtoInstance.IsImpliedIncluded = isImpliedIncludedProperty.GetBoolean();
                }
            }
            else
            {
                logger.LogDebug($"the isImpliedIncluded Json property was not found in the AnnotatingElement: {dtoInstance.Id}");
            }

            if (jsonElement.TryGetProperty("name", out JsonElement nameProperty))
            {
                var propertyValue = nameProperty.GetString();
                if (propertyValue != null)
                {
                    dtoInstance.Name = propertyValue;
                }
            }
            else
            {
                logger.LogDebug($"the name Json property was not found in the AnnotatingElement: {dtoInstance.Id}");
            }

            if (jsonElement.TryGetProperty("ownedRelationship", out JsonElement ownedRelationshipProperty))
            {
                foreach (var arrayItem in ownedRelationshipProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id", out JsonElement ownedRelationshipIdProperty))
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
                logger.LogDebug($"the ownedRelationship Json property was not found in the AnnotatingElement: {dtoInstance.Id}");
            }

            if (jsonElement.TryGetProperty("owningRelationship", out JsonElement owningRelationshipProperty))
            {
                if (owningRelationshipProperty.ValueKind == JsonValueKind.Null)
                {
                    dtoInstance.OwningRelationship = null;
                }
                else
                {
                    if (owningRelationshipProperty.TryGetProperty("@id", out JsonElement owningRelationshipIdProperty))
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
                logger.LogDebug($"the owningRelationship Json property was not found in the AnnotatingElement: {dtoInstance.Id}");
            }

            if (jsonElement.TryGetProperty("shortName", out JsonElement shortNameProperty))
            {
                var propertyValue = shortNameProperty.GetString();
                if (propertyValue != null)
                {
                    dtoInstance.ShortName = propertyValue;
                }
            }
            else
            {
                logger.LogDebug($"the shortName Json property was not found in the AnnotatingElement: {dtoInstance.Id}");
            }


            return dtoInstance;
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
