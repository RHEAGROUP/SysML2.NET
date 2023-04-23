﻿// -------------------------------------------------------------------------------------------------
// <copyright file="DecisionNodeSerializer.cs" company="RHEA System S.A.">
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

namespace SysML2.NET.Serializer.Json
{
    using System;
    using System.Text.Json;

    using SysML2.NET.Common;
    using SysML2.NET.Core.DTO;

    /// <summary>
    /// The purpose of the <see cref="DecisionNodeSerializer"/> is to provide serialization capabilities
    /// capabilities for the <see cref="IDecisionNode"/> interface
    /// </summary>
    internal static class DecisionNodeSerializer
    {
        /// <summary>
        /// Serializes an instance of <see cref="IDecisionNode"/> using an <see cref="Utf8JsonWriter"/>
        /// </summary>
        /// <param name="obj">
        /// The <see cref="IDecisionNode"/> to serialize
        /// </param>
        /// <param name="writer">
        /// The target <see cref="Utf8JsonWriter"/>
        /// </param>
        /// <param name="serializationModeKind">
        /// enumeration specifying what kind of serialization shall be used
        /// </param>
        internal static void Serialize(object obj, Utf8JsonWriter writer, SerializationModeKind serializationModeKind)
        {
            if (!(obj is IDecisionNode iDecisionNode))
            {
                throw new ArgumentException("The object shall be an IDecisionNode", nameof(obj));
            }

            writer.WriteStartObject();

            writer.WritePropertyName("@type"u8);
            writer.WriteStringValue("DecisionNode"u8);

            writer.WritePropertyName("@id"u8);
            writer.WriteStringValue(iDecisionNode.Id);

            writer.WriteStartArray("aliasIds"u8);
            foreach (var item in iDecisionNode.AliasIds)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();

            writer.WritePropertyName("declaredName"u8);
            writer.WriteStringValue(iDecisionNode.DeclaredName);
            writer.WritePropertyName("declaredShortName"u8);
            writer.WriteStringValue(iDecisionNode.DeclaredShortName);
            writer.WritePropertyName("direction"u8);
            if (iDecisionNode.Direction.HasValue)
            {
                writer.WriteStringValue(iDecisionNode.Direction.Value.ToString().ToLower());
            }
            else
            {
                writer.WriteNullValue();
            }
            writer.WritePropertyName("elementId"u8);
            writer.WriteStringValue(iDecisionNode.ElementId);

            writer.WritePropertyName("isAbstract"u8);
            writer.WriteBooleanValue(iDecisionNode.IsAbstract);

            writer.WritePropertyName("isComposite"u8);
            writer.WriteBooleanValue(iDecisionNode.IsComposite);

            writer.WritePropertyName("isDerived"u8);
            writer.WriteBooleanValue(iDecisionNode.IsDerived);

            writer.WritePropertyName("isEnd"u8);
            writer.WriteBooleanValue(iDecisionNode.IsEnd);

            writer.WritePropertyName("isImpliedIncluded"u8);
            writer.WriteBooleanValue(iDecisionNode.IsImpliedIncluded);

            writer.WritePropertyName("isIndividual"u8);
            writer.WriteBooleanValue(iDecisionNode.IsIndividual);

            writer.WritePropertyName("isOrdered"u8);
            writer.WriteBooleanValue(iDecisionNode.IsOrdered);

            writer.WritePropertyName("isPortion"u8);
            writer.WriteBooleanValue(iDecisionNode.IsPortion);

            writer.WritePropertyName("isReadOnly"u8);
            writer.WriteBooleanValue(iDecisionNode.IsReadOnly);

            writer.WritePropertyName("isSufficient"u8);
            writer.WriteBooleanValue(iDecisionNode.IsSufficient);

            writer.WritePropertyName("isUnique"u8);
            writer.WriteBooleanValue(iDecisionNode.IsUnique);

            writer.WritePropertyName("isVariation"u8);
            writer.WriteBooleanValue(iDecisionNode.IsVariation);

            writer.WriteStartArray("ownedRelationship"u8);
            foreach (var item in iDecisionNode.OwnedRelationship)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();

            writer.WritePropertyName("owningRelationship"u8);
            if (iDecisionNode.OwningRelationship.HasValue)
            {
                writer.WriteStringValue(iDecisionNode.OwningRelationship.Value);
            }
            else
            {
                writer.WriteNullValue();
            }
            writer.WritePropertyName("portionKind"u8);
            if (iDecisionNode.PortionKind.HasValue)
            {
                writer.WriteStringValue(iDecisionNode.PortionKind.Value.ToString().ToLower());
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