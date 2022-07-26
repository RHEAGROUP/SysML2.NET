// -------------------------------------------------------------------------------------------------
// <copyright file="FlowConnectionDefinitionSerializer.cs" company="RHEA System S.A.">
//
// Copyright 2022 RHEA System S.A.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
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

    using SysML2.NET.Common;
    using SysML2.NET.Core.DTO;

    /// <summary>
    /// The purpose of the <see cref="FlowConnectionDefinitionSerializer"/> is to provide serialization
    /// and deserialization capabilities
    /// </summary>
    internal static class FlowConnectionDefinitionSerializer
    {
        /// <summary>
        /// Serializes an instance of <see cref="IFlowConnectionDefinition"/> using an <see cref="Utf8JsonWriter"/>
        /// </summary>
        /// <param name="obj">
        /// The <see cref="IFlowConnectionDefinition"/> to serialize
        /// </param>
        /// <param name="writer">
        /// The target <see cref="Utf8JsonWriter"/>
        /// </param>
        /// <param name="serializationModeKind">
        /// enumeration specifying what kind of serialization shall be used
        /// </param>
        internal static void Serialize(object obj, Utf8JsonWriter writer, SerializationModeKind serializationModeKind)
        {
            if (!(obj is IFlowConnectionDefinition iFlowConnectionDefinition))
            {
                throw new ArgumentException("The object shall be an IFlowConnectionDefinition", nameof(obj));
            }

            writer.WriteStartObject();

            writer.WritePropertyName("@type");
            writer.WriteStringValue("FlowConnectionDefinition");

            writer.WritePropertyName("@id");
            writer.WriteStringValue(iFlowConnectionDefinition.Id);

            writer.WriteStartArray("aliasIds");
            foreach (var item in iFlowConnectionDefinition.AliasIds)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();

            writer.WritePropertyName("elementId");
            writer.WriteStringValue(iFlowConnectionDefinition.ElementId);

            writer.WritePropertyName("isAbstract");
            writer.WriteBooleanValue(iFlowConnectionDefinition.IsAbstract);

            writer.WritePropertyName("isImplied");
            writer.WriteBooleanValue(iFlowConnectionDefinition.IsImplied);

            writer.WritePropertyName("isImpliedIncluded");
            writer.WriteBooleanValue(iFlowConnectionDefinition.IsImpliedIncluded);

            writer.WritePropertyName("isIndividual");
            writer.WriteBooleanValue(iFlowConnectionDefinition.IsIndividual);

            writer.WritePropertyName("isSufficient");
            writer.WriteBooleanValue(iFlowConnectionDefinition.IsSufficient);

            writer.WritePropertyName("isVariation");
            writer.WriteBooleanValue(iFlowConnectionDefinition.IsVariation);

            writer.WritePropertyName("name");
            writer.WriteStringValue(iFlowConnectionDefinition.Name);

            writer.WriteStartArray("ownedRelatedElement");
            foreach (var item in iFlowConnectionDefinition.OwnedRelatedElement)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();

            writer.WriteStartArray("ownedRelationship");
            foreach (var item in iFlowConnectionDefinition.OwnedRelationship)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();

            writer.WritePropertyName("owningRelatedElement");
            if (iFlowConnectionDefinition.OwningRelatedElement.HasValue)
            {
                writer.WriteStringValue(iFlowConnectionDefinition.OwningRelatedElement.Value);
            }
            else
            {
                writer.WriteNullValue();
            }

            writer.WritePropertyName("owningRelationship");
            if (iFlowConnectionDefinition.OwningRelationship.HasValue)
            {
                writer.WriteStringValue(iFlowConnectionDefinition.OwningRelationship.Value);
            }
            else
            {
                writer.WriteNullValue();
            }

            writer.WritePropertyName("shortName");
            writer.WriteStringValue(iFlowConnectionDefinition.ShortName);

            writer.WriteStartArray("source");
            foreach (var item in iFlowConnectionDefinition.Source)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();

            writer.WriteStartArray("target");
            foreach (var item in iFlowConnectionDefinition.Target)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();

            writer.WriteEndObject();
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
