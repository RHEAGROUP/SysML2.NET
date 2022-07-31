// -------------------------------------------------------------------------------------------------
// <copyright file="SuccessionFlowConnectionUsageSerializer.cs" company="RHEA System S.A.">
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

    using SysML2.NET.DTO;

    /// <summary>
    /// The purpose of the <see cref="SuccessionFlowConnectionUsageSerializer"/> is to provide serialization
    /// and deserialization capabilities
    /// </summary>
    internal static class SuccessionFlowConnectionUsageSerializer
    {
        /// <summary>
        /// Serializes an instance of <see cref="ISuccessionFlowConnectionUsage"/> using an <see cref="Utf8JsonWriter"/>
        /// </summary>
        /// <param name="obj">
        /// The <see cref="ISuccessionFlowConnectionUsage"/> to serialize
        /// </param>
        /// <param name="writer">
        /// The target <see cref="Utf8JsonWriter"/>
        /// </param>
        /// <param name="serializationModeKind">
        /// enumeration specifying what kind of serialization shall be used
        /// </param>
        internal static void Serialize(object obj, Utf8JsonWriter writer, SerializationModeKind serializationModeKind)
        {
            if (!(obj is ISuccessionFlowConnectionUsage iSuccessionFlowConnectionUsage))
            {
                throw new ArgumentException("The object shall be an ISuccessionFlowConnectionUsage", nameof(obj));
            }

            writer.WriteStartObject();

            writer.WritePropertyName("@id");
            writer.WriteStringValue(iSuccessionFlowConnectionUsage.Id);

            writer.WritePropertyName("@type");
            writer.WriteStringValue("SuccessionFlowConnectionUsage");

            writer.WritePropertyName("isVariation");
            writer.WriteBooleanValue(iSuccessionFlowConnectionUsage.IsVariation);

            writer.WritePropertyName("direction");
            if (iSuccessionFlowConnectionUsage.Direction.HasValue)
            {
                writer.WriteStringValue(iSuccessionFlowConnectionUsage.Direction.Value.ToString().ToUpper());
            }
            else
            {
                writer.WriteNullValue();
            }

            writer.WritePropertyName("isComposite");
            writer.WriteBooleanValue(iSuccessionFlowConnectionUsage.IsComposite);

            writer.WritePropertyName("isDerived");
            writer.WriteBooleanValue(iSuccessionFlowConnectionUsage.IsDerived);

            writer.WritePropertyName("isEnd");
            writer.WriteBooleanValue(iSuccessionFlowConnectionUsage.IsEnd);

            writer.WritePropertyName("isOrdered");
            writer.WriteBooleanValue(iSuccessionFlowConnectionUsage.IsOrdered);

            writer.WritePropertyName("isPortion");
            writer.WriteBooleanValue(iSuccessionFlowConnectionUsage.IsPortion);

            writer.WritePropertyName("isReadOnly");
            writer.WriteBooleanValue(iSuccessionFlowConnectionUsage.IsReadOnly);

            writer.WritePropertyName("isUnique");
            writer.WriteBooleanValue(iSuccessionFlowConnectionUsage.IsUnique);

            writer.WritePropertyName("isAbstract");
            writer.WriteBooleanValue(iSuccessionFlowConnectionUsage.IsAbstract);

            writer.WritePropertyName("isSufficient");
            writer.WriteBooleanValue(iSuccessionFlowConnectionUsage.IsSufficient);

            writer.WriteStartArray("aliasIds");
            foreach (var item in iSuccessionFlowConnectionUsage.AliasIds)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();

            writer.WritePropertyName("elementId");
            writer.WriteStringValue(iSuccessionFlowConnectionUsage.ElementId);

            writer.WritePropertyName("name");
            writer.WriteStringValue(iSuccessionFlowConnectionUsage.Name);

            writer.WriteStartArray("ownedRelationship");
            foreach (var item in iSuccessionFlowConnectionUsage.OwnedRelationship)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();

            writer.WritePropertyName("owningRelationship");
            if (iSuccessionFlowConnectionUsage.OwningRelationship.HasValue)
            {
                writer.WriteStringValue(iSuccessionFlowConnectionUsage.OwningRelationship.Value);
            }
            else
            {
                writer.WriteNullValue();
            }

            writer.WritePropertyName("shortName");
            writer.WriteStringValue(iSuccessionFlowConnectionUsage.ShortName);

            writer.WritePropertyName("isDirected");
            writer.WriteBooleanValue(iSuccessionFlowConnectionUsage.IsDirected);

            writer.WriteStartArray("ownedRelatedElement");
            foreach (var item in iSuccessionFlowConnectionUsage.OwnedRelatedElement)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();

            writer.WritePropertyName("owningRelatedElement");
            if (iSuccessionFlowConnectionUsage.OwningRelatedElement.HasValue)
            {
                writer.WriteStringValue(iSuccessionFlowConnectionUsage.OwningRelatedElement.Value);
            }
            else
            {
                writer.WriteNullValue();
            }

            writer.WriteStartArray("source");
            foreach (var item in iSuccessionFlowConnectionUsage.Source)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();

            writer.WriteStartArray("target");
            foreach (var item in iSuccessionFlowConnectionUsage.Target)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();

            writer.WritePropertyName("isIndividual");
            writer.WriteBooleanValue(iSuccessionFlowConnectionUsage.IsIndividual);

            writer.WritePropertyName("portionKind");
            if (iSuccessionFlowConnectionUsage.PortionKind.HasValue)
            {
                writer.WriteStringValue(iSuccessionFlowConnectionUsage.PortionKind.Value.ToString().ToUpper());
            }
            else
            {
                writer.WriteNullValue();
            }

            writer.WriteEndObject();
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------