﻿// -------------------------------------------------------------------------------------------------
// <copyright file="ConnectionDefinitionSerializer.cs" company="RHEA System S.A.">
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

    using SysML2.NET.Common;
    using SysML2.NET.Core.DTO;
    using SysML2.NET.Serializer.Json;

    /// <summary>
    /// The purpose of the <see cref="ConnectionDefinitionSerializer"/> is to provide serialization capabilities
    /// capabilities for the <see cref="IConnectionDefinition"/> interface
    /// </summary>
    internal static class ConnectionDefinitionSerializer
    {
        /// <summary>
        /// Serializes an instance of <see cref="IConnectionDefinition"/> using an <see cref="Utf8JsonWriter"/>
        /// </summary>
        /// <param name="obj">
        /// The <see cref="IConnectionDefinition"/> to serialize
        /// </param>
        /// <param name="writer">
        /// The target <see cref="Utf8JsonWriter"/>
        /// </param>
        /// <param name="serializationModeKind">
        /// enumeration specifying what kind of serialization shall be used
        /// </param>
        internal static void Serialize(object obj, Utf8JsonWriter writer, SerializationModeKind serializationModeKind)
        {
            if (!(obj is IConnectionDefinition iConnectionDefinition))
            {
                throw new ArgumentException("The object shall be an IConnectionDefinition", nameof(obj));
            }

            writer.WriteStartObject();

            writer.WritePropertyName("@type"u8);
            writer.WriteStringValue("ConnectionDefinition"u8);

            writer.WritePropertyName("@id"u8);
            writer.WriteStringValue(iConnectionDefinition.Id);

            writer.WriteStartArray("aliasIds"u8);
            foreach (var item in iConnectionDefinition.AliasIds)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();

            writer.WritePropertyName("declaredName"u8);
            writer.WriteStringValue(iConnectionDefinition.DeclaredName);
            writer.WritePropertyName("declaredShortName"u8);
            writer.WriteStringValue(iConnectionDefinition.DeclaredShortName);
            writer.WritePropertyName("elementId"u8);
            writer.WriteStringValue(iConnectionDefinition.ElementId);

            writer.WritePropertyName("isAbstract"u8);
            writer.WriteBooleanValue(iConnectionDefinition.IsAbstract);

            writer.WritePropertyName("isImplied"u8);
            writer.WriteBooleanValue(iConnectionDefinition.IsImplied);

            writer.WritePropertyName("isImpliedIncluded"u8);
            writer.WriteBooleanValue(iConnectionDefinition.IsImpliedIncluded);

            writer.WritePropertyName("isIndividual"u8);
            writer.WriteBooleanValue(iConnectionDefinition.IsIndividual);

            writer.WritePropertyName("isSufficient"u8);
            writer.WriteBooleanValue(iConnectionDefinition.IsSufficient);

            writer.WritePropertyName("isVariation"u8);
            writer.WriteBooleanValue(iConnectionDefinition.IsVariation);

            writer.WriteStartArray("ownedRelatedElement"u8);
            foreach (var item in iConnectionDefinition.OwnedRelatedElement)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();

            writer.WriteStartArray("ownedRelationship"u8);
            foreach (var item in iConnectionDefinition.OwnedRelationship)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();

            writer.WritePropertyName("owningRelatedElement"u8);
            if (iConnectionDefinition.OwningRelatedElement.HasValue)
            {
                writer.WriteStringValue(iConnectionDefinition.OwningRelatedElement.Value);
            }
            else
            {
                writer.WriteNullValue();
            }
            writer.WritePropertyName("owningRelationship"u8);
            if (iConnectionDefinition.OwningRelationship.HasValue)
            {
                writer.WriteStringValue(iConnectionDefinition.OwningRelationship.Value);
            }
            else
            {
                writer.WriteNullValue();
            }
            writer.WriteStartArray("source"u8);
            foreach (var item in iConnectionDefinition.Source)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();

            writer.WriteStartArray("target"u8);
            foreach (var item in iConnectionDefinition.Target)
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
