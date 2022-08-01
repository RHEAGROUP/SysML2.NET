// -------------------------------------------------------------------------------------------------
// <copyright file="FeatureMembershipDeSerializer.cs" company="RHEA System S.A.">
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

    using SysML2.NET.DTO;

    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Logging.Abstractions;

    /// <summary>
    /// The purpose of the <see cref="FeatureMembershipDeSerializer"/> is to provide deserialization capabilities
    /// for the <see cref="IFeatureMembership"/> interface
    /// </summary>
    internal static class FeatureMembershipDeSerializer
    {
        /// <summary>
        /// Deserializes an instance of <see cref="IFeatureMembership"/> from the provided <see cref="JsonElement"/>
        /// </summary>
        /// <param name="jsonElement">
        /// The <see cref="JsonElement"/> that contains the <see cref="IFeatureMembership"/> json object
        /// </param>
        /// <param name="serializationModeKind">
        /// enumeration specifying what kind of serialization shall be used
        /// </param>
        /// <param name="loggerFactory">
        /// The <see cref="ILoggerFactory"/> used to setup logging
        /// </param>
        /// <returns>
        /// an instance of <see cref="IFeatureMembership"/>
        /// </returns>
        internal static IFeatureMembership DeSerialize(JsonElement jsonElement, SerializationModeKind serializationModeKind, ILoggerFactory loggerFactory = null)
        {
            var logger = loggerFactory == null ? NullLogger.Instance : loggerFactory.CreateLogger("FeatureMembershipDeSerializer");

            if (!jsonElement.TryGetProperty("@type", out JsonElement @type))
            {
                throw new InvalidOperationException("The @type property is not available, the FeatureMembershipDeSerializer cannot be used to deserialize this JsonElement");
            }

            if (@type.GetString() != "FeatureMembership")
            {
                throw new InvalidOperationException($"The FeatureMembershipDeSerializer can only be used to deserialize objects of type IFeatureMembership, a {@type.GetString()} was provided");
            }

            var dtoInstance = new DTO.FeatureMembership();

            if (jsonElement.TryGetProperty("@id", out JsonElement idProperty))
            {
                var propertyValue = idProperty.GetString();
                if (propertyValue == null)
                {
                    throw new JsonException("The @id property is not present, the FeatureMembership cannot be deserialized");
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
                logger.LogDebug($"the aliasIds Json property was not found in the FeatureMembership: {dtoInstance.Id}");
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
                logger.LogDebug($"the elementId Json property was not found in the FeatureMembership: {dtoInstance.Id}");
            }

            if (jsonElement.TryGetProperty("featureOfType", out JsonElement featureOfTypeProperty))
            {
                if (featureOfTypeProperty.TryGetProperty("@id", out JsonElement featureOfTypeIdProperty))
                {
                    var propertyValue = featureOfTypeIdProperty.GetString();
                    if (propertyValue != null)
                    {
                        dtoInstance.FeatureOfType = Guid.Parse(propertyValue);
                    }
                }
            }
            else
            {
                logger.LogDebug($"the featureOfType Json property was not found in the FeatureMembership: {dtoInstance.Id}");
            }

            if (jsonElement.TryGetProperty("featuringType", out JsonElement featuringTypeProperty))
            {
                if (featuringTypeProperty.TryGetProperty("@id", out JsonElement featuringTypeIdProperty))
                {
                    var propertyValue = featuringTypeIdProperty.GetString();
                    if (propertyValue != null)
                    {
                        dtoInstance.FeaturingType = Guid.Parse(propertyValue);
                    }
                }
            }
            else
            {
                logger.LogDebug($"the featuringType Json property was not found in the FeatureMembership: {dtoInstance.Id}");
            }

            if (jsonElement.TryGetProperty("memberElement", out JsonElement memberElementProperty))
            {
                if (memberElementProperty.TryGetProperty("@id", out JsonElement memberElementIdProperty))
                {
                    var propertyValue = memberElementIdProperty.GetString();
                    if (propertyValue != null)
                    {
                        dtoInstance.MemberElement = Guid.Parse(propertyValue);
                    }
                }
            }
            else
            {
                logger.LogDebug($"the memberElement Json property was not found in the FeatureMembership: {dtoInstance.Id}");
            }

            if (jsonElement.TryGetProperty("memberName", out JsonElement memberNameProperty))
            {
                var propertyValue = memberNameProperty.GetString();
                if (propertyValue != null)
                {
                    dtoInstance.MemberName = propertyValue;
                }
            }
            else
            {
                logger.LogDebug($"the memberName Json property was not found in the FeatureMembership: {dtoInstance.Id}");
            }

            if (jsonElement.TryGetProperty("memberShortName", out JsonElement memberShortNameProperty))
            {
                var propertyValue = memberShortNameProperty.GetString();
                if (propertyValue != null)
                {
                    dtoInstance.MemberShortName = propertyValue;
                }
            }
            else
            {
                logger.LogDebug($"the memberShortName Json property was not found in the FeatureMembership: {dtoInstance.Id}");
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
                logger.LogDebug($"the name Json property was not found in the FeatureMembership: {dtoInstance.Id}");
            }

            if (jsonElement.TryGetProperty("ownedRelatedElement", out JsonElement ownedRelatedElementProperty))
            {
                foreach (var arrayItem in ownedRelatedElementProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id", out JsonElement ownedRelatedElementIdProperty))
                    {
                        var propertyValue = ownedRelatedElementIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.OwnedRelatedElement.Add(Guid.Parse(propertyValue));
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the ownedRelatedElement Json property was not found in the FeatureMembership: {dtoInstance.Id}");
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
                logger.LogDebug($"the ownedRelationship Json property was not found in the FeatureMembership: {dtoInstance.Id}");
            }

            if (jsonElement.TryGetProperty("owningRelatedElement", out JsonElement owningRelatedElementProperty))
            {
                if (owningRelatedElementProperty.TryGetProperty("@id", out JsonElement owningRelatedElementIdProperty))
                {
                    var propertyValue = owningRelatedElementIdProperty.GetString();
                    if (propertyValue != null)
                    {
                        dtoInstance.OwningRelatedElement = Guid.Parse(propertyValue);
                    }
                }
            }
            else
            {
                logger.LogDebug($"the owningRelatedElement Json property was not found in the FeatureMembership: {dtoInstance.Id}");
            }

            if (jsonElement.TryGetProperty("owningRelationship", out JsonElement owningRelationshipProperty))
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
            else
            {
                logger.LogDebug($"the owningRelationship Json property was not found in the FeatureMembership: {dtoInstance.Id}");
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
                logger.LogDebug($"the shortName Json property was not found in the FeatureMembership: {dtoInstance.Id}");
            }

            if (jsonElement.TryGetProperty("source", out JsonElement sourceProperty))
            {
                foreach (var arrayItem in sourceProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id", out JsonElement sourceIdProperty))
                    {
                        var propertyValue = sourceIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.Source.Add(Guid.Parse(propertyValue));
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the source Json property was not found in the FeatureMembership: {dtoInstance.Id}");
            }

            if (jsonElement.TryGetProperty("target", out JsonElement targetProperty))
            {
                foreach (var arrayItem in targetProperty.EnumerateArray())
                {
                    if (arrayItem.TryGetProperty("@id", out JsonElement targetIdProperty))
                    {
                        var propertyValue = targetIdProperty.GetString();
                        if (propertyValue != null)
                        {
                            dtoInstance.Target.Add(Guid.Parse(propertyValue));
                        }
                    }
                }
            }
            else
            {
                logger.LogDebug($"the target Json property was not found in the FeatureMembership: {dtoInstance.Id}");
            }

            if (jsonElement.TryGetProperty("visibility", out JsonElement visibilityProperty))
            {
                throw new NotImplementedException("FeatureMembership.visibility is not yet supported");
            }
            else
            {
                logger.LogDebug($"the visibility Json property was not found in the FeatureMembership: {dtoInstance.Id}");
            }


            return dtoInstance;
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
