﻿// -------------------------------------------------------------------------------------------------
// <copyright file="AssertConstraintUsageSerializer.cs" company="RHEA System S.A.">
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
    /// The purpose of the <see cref="AssertConstraintUsageSerializer"/> is to provide serialization
    /// and deserialization capabilities
    /// </summary>
    internal static class AssertConstraintUsageSerializer
    {
        /// <summary>
        /// Serializes an instance of <see cref="IAssertConstraintUsage"/> using an <see cref="Utf8JsonWriter"/>
        /// </summary>
        /// <param name="obj">
        /// The <see cref="IAssertConstraintUsage"/> to serialize
        /// </param>
        /// <param name="writer">
        /// The target <see cref="Utf8JsonWriter"/>
        /// </param>
        /// <param name="serializationModeKind">
        /// enumeration specifying what kind of serialization shall be used
        /// </param>
        internal static void Serialize(object obj, Utf8JsonWriter writer, SerializationModeKind serializationModeKind)
        {
            if (!(obj is IAssertConstraintUsage iAssertConstraintUsage))
            {
                throw new ArgumentException("The object shall be an IAssertConstraintUsage", nameof(obj));
            }

            writer.WriteStartObject();

            writer.WritePropertyName("@type");
            writer.WriteStringValue("AssertConstraintUsage");

            writer.WritePropertyName("@id");
            writer.WriteStringValue(iAssertConstraintUsage.Id);

            writer.WriteStartArray("aliasIds");
            foreach (var item in iAssertConstraintUsage.AliasIds)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();

            writer.WritePropertyName("direction");
            if (iAssertConstraintUsage.Direction.HasValue)
            {
                writer.WriteStringValue(iAssertConstraintUsage.Direction.Value.ToString().ToLower());
            }
            else
            {
                writer.WriteNullValue();
            }
            writer.WritePropertyName("elementId");
            writer.WriteStringValue(iAssertConstraintUsage.ElementId);

            writer.WritePropertyName("isAbstract");
            writer.WriteBooleanValue(iAssertConstraintUsage.IsAbstract);

            writer.WritePropertyName("isComposite");
            writer.WriteBooleanValue(iAssertConstraintUsage.IsComposite);

            writer.WritePropertyName("isDerived");
            writer.WriteBooleanValue(iAssertConstraintUsage.IsDerived);

            writer.WritePropertyName("isEnd");
            writer.WriteBooleanValue(iAssertConstraintUsage.IsEnd);

            writer.WritePropertyName("isImpliedIncluded");
            writer.WriteBooleanValue(iAssertConstraintUsage.IsImpliedIncluded);

            writer.WritePropertyName("isIndividual");
            writer.WriteBooleanValue(iAssertConstraintUsage.IsIndividual);

            writer.WritePropertyName("isNegated");
            writer.WriteBooleanValue(iAssertConstraintUsage.IsNegated);

            writer.WritePropertyName("isOrdered");
            writer.WriteBooleanValue(iAssertConstraintUsage.IsOrdered);

            writer.WritePropertyName("isPortion");
            writer.WriteBooleanValue(iAssertConstraintUsage.IsPortion);

            writer.WritePropertyName("isReadOnly");
            writer.WriteBooleanValue(iAssertConstraintUsage.IsReadOnly);

            writer.WritePropertyName("isSufficient");
            writer.WriteBooleanValue(iAssertConstraintUsage.IsSufficient);

            writer.WritePropertyName("isUnique");
            writer.WriteBooleanValue(iAssertConstraintUsage.IsUnique);

            writer.WritePropertyName("isVariation");
            writer.WriteBooleanValue(iAssertConstraintUsage.IsVariation);

            writer.WritePropertyName("name");
            writer.WriteStringValue(iAssertConstraintUsage.Name);
            writer.WriteStartArray("ownedRelationship");
            foreach (var item in iAssertConstraintUsage.OwnedRelationship)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();

            writer.WritePropertyName("owningRelationship");
            if (iAssertConstraintUsage.OwningRelationship.HasValue)
            {
                writer.WriteStringValue(iAssertConstraintUsage.OwningRelationship.Value);
            }
            else
            {
                writer.WriteNullValue();
            }
            writer.WritePropertyName("portionKind");
            if (iAssertConstraintUsage.PortionKind.HasValue)
            {
                writer.WriteStringValue(iAssertConstraintUsage.PortionKind.Value.ToString().ToLower());
            }
            else
            {
                writer.WriteNullValue();
            }
            writer.WritePropertyName("shortName");
            writer.WriteStringValue(iAssertConstraintUsage.ShortName);
            writer.WriteEndObject();
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
