// -------------------------------------------------------------------------------------------------
// <copyright file="AttributeUsageSerializer.cs" company="RHEA System S.A.">
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
    /// The purpose of the <see cref="AttributeUsageSerializer"/> is to provide serialization
    /// and deserialization capabilities
    /// </summary>
    internal static class AttributeUsageSerializer
    {
        /// <summary>
        /// Serializes an instance of <see cref="IAttributeUsage"/> using an <see cref="Utf8JsonWriter"/>
        /// </summary>
        /// <param name="obj">
        /// The <see cref="IAttributeUsage"/> to serialize
        /// </param>
        /// <param name="writer">
        /// The target <see cref="Utf8JsonWriter"/>
        /// </param>
        /// <param name="serializationModeKind">
        /// enumeration specifying what kind of serialization shall be used
        /// </param>
        internal static void Serialize(object obj, Utf8JsonWriter writer, SerializationModeKind serializationModeKind)
        {
            if (!(obj is IAttributeUsage iAttributeUsage))
            {
                throw new ArgumentException("The object shall be an IAttributeUsage", nameof(obj));
            }

            writer.WriteStartObject();

            writer.WritePropertyName("@type");
            writer.WriteStringValue("AttributeUsage");

            writer.WritePropertyName("@id");
            writer.WriteStringValue(iAttributeUsage.Id);

            writer.WriteStartArray("aliasIds");
            foreach (var item in iAttributeUsage.AliasIds)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();

            writer.WritePropertyName("direction");
            if (iAttributeUsage.Direction.HasValue)
            {
                writer.WriteStringValue(iAttributeUsage.Direction.Value.ToString().ToLower());
            }
            else
            {
                writer.WriteNullValue();
            }

            writer.WritePropertyName("elementId");
            writer.WriteStringValue(iAttributeUsage.ElementId);

            writer.WritePropertyName("isAbstract");
            writer.WriteBooleanValue(iAttributeUsage.IsAbstract);

            writer.WritePropertyName("isComposite");
            writer.WriteBooleanValue(iAttributeUsage.IsComposite);

            writer.WritePropertyName("isDerived");
            writer.WriteBooleanValue(iAttributeUsage.IsDerived);

            writer.WritePropertyName("isEnd");
            writer.WriteBooleanValue(iAttributeUsage.IsEnd);

            writer.WritePropertyName("isImpliedIncluded");
            writer.WriteBooleanValue(iAttributeUsage.IsImpliedIncluded);

            writer.WritePropertyName("isOrdered");
            writer.WriteBooleanValue(iAttributeUsage.IsOrdered);

            writer.WritePropertyName("isPortion");
            writer.WriteBooleanValue(iAttributeUsage.IsPortion);

            writer.WritePropertyName("isReadOnly");
            writer.WriteBooleanValue(iAttributeUsage.IsReadOnly);

            writer.WritePropertyName("isSufficient");
            writer.WriteBooleanValue(iAttributeUsage.IsSufficient);

            writer.WritePropertyName("isUnique");
            writer.WriteBooleanValue(iAttributeUsage.IsUnique);

            writer.WritePropertyName("isVariation");
            writer.WriteBooleanValue(iAttributeUsage.IsVariation);

            writer.WritePropertyName("name");
            writer.WriteStringValue(iAttributeUsage.Name);

            writer.WriteStartArray("ownedRelationship");
            foreach (var item in iAttributeUsage.OwnedRelationship)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();

            writer.WritePropertyName("owningRelationship");
            if (iAttributeUsage.OwningRelationship.HasValue)
            {
                writer.WriteStringValue(iAttributeUsage.OwningRelationship.Value);
            }
            else
            {
                writer.WriteNullValue();
            }

            writer.WritePropertyName("shortName");
            writer.WriteStringValue(iAttributeUsage.ShortName);

            writer.WriteEndObject();
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
