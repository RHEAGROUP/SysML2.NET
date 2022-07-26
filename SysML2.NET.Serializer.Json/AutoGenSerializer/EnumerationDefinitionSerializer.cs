// -------------------------------------------------------------------------------------------------
// <copyright file="EnumerationDefinitionSerializer.cs" company="RHEA System S.A.">
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
    /// The purpose of the <see cref="EnumerationDefinitionSerializer"/> is to provide serialization
    /// and deserialization capabilities
    /// </summary>
    internal static class EnumerationDefinitionSerializer
    {
        /// <summary>
        /// Serializes an instance of <see cref="IEnumerationDefinition"/> using an <see cref="Utf8JsonWriter"/>
        /// </summary>
        /// <param name="obj">
        /// The <see cref="IEnumerationDefinition"/> to serialize
        /// </param>
        /// <param name="writer">
        /// The target <see cref="Utf8JsonWriter"/>
        /// </param>
        /// <param name="serializationModeKind">
        /// enumeration specifying what kind of serialization shall be used
        /// </param>
        internal static void Serialize(object obj, Utf8JsonWriter writer, SerializationModeKind serializationModeKind)
        {
            if (!(obj is IEnumerationDefinition iEnumerationDefinition))
            {
                throw new ArgumentException("The object shall be an IEnumerationDefinition", nameof(obj));
            }

            writer.WriteStartObject();

            writer.WritePropertyName("@type");
            writer.WriteStringValue("EnumerationDefinition");

            writer.WritePropertyName("@id");
            writer.WriteStringValue(iEnumerationDefinition.Id);

            writer.WriteStartArray("aliasIds");
            foreach (var item in iEnumerationDefinition.AliasIds)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();

            writer.WritePropertyName("elementId");
            writer.WriteStringValue(iEnumerationDefinition.ElementId);

            writer.WritePropertyName("isAbstract");
            writer.WriteBooleanValue(iEnumerationDefinition.IsAbstract);

            writer.WritePropertyName("isImpliedIncluded");
            writer.WriteBooleanValue(iEnumerationDefinition.IsImpliedIncluded);

            writer.WritePropertyName("isSufficient");
            writer.WriteBooleanValue(iEnumerationDefinition.IsSufficient);

            writer.WritePropertyName("isVariation");
            writer.WriteBooleanValue(iEnumerationDefinition.IsVariation);

            writer.WritePropertyName("name");
            writer.WriteStringValue(iEnumerationDefinition.Name);

            writer.WriteStartArray("ownedRelationship");
            foreach (var item in iEnumerationDefinition.OwnedRelationship)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();

            writer.WritePropertyName("owningRelationship");
            if (iEnumerationDefinition.OwningRelationship.HasValue)
            {
                writer.WriteStringValue(iEnumerationDefinition.OwningRelationship.Value);
            }
            else
            {
                writer.WriteNullValue();
            }

            writer.WritePropertyName("shortName");
            writer.WriteStringValue(iEnumerationDefinition.ShortName);

            writer.WriteEndObject();
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
