// -------------------------------------------------------------------------------------------------
// <copyright file="ItemFlowEndSerializer.cs" company="RHEA System S.A.">
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
    /// The purpose of the <see cref="ItemFlowEndSerializer"/> is to provide serialization
    /// and deserialization capabilities
    /// </summary>
    internal static class ItemFlowEndSerializer
    {
        /// <summary>
        /// Serializes an instance of <see cref="IItemFlowEnd"/> using an <see cref="Utf8JsonWriter"/>
        /// </summary>
        /// <param name="obj">
        /// The <see cref="IItemFlowEnd"/> to serialize
        /// </param>
        /// <param name="writer">
        /// The target <see cref="Utf8JsonWriter"/>
        /// </param>
        /// <param name="serializationModeKind">
        /// enumeration specifying what kind of serialization shall be used
        /// </param>
        internal static void Serialize(object obj, Utf8JsonWriter writer, SerializationModeKind serializationModeKind)
        {
            if (!(obj is IItemFlowEnd iItemFlowEnd))
            {
                throw new ArgumentException("The object shall be an IItemFlowEnd", nameof(obj));
            }

            writer.WriteStartObject();

            writer.WritePropertyName("@type");
            writer.WriteStringValue("ItemFlowEnd");

            writer.WritePropertyName("@id");
            writer.WriteStringValue(iItemFlowEnd.Id);

            writer.WriteStartArray("aliasIds");
            foreach (var item in iItemFlowEnd.AliasIds)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();

            writer.WritePropertyName("direction");
            if (iItemFlowEnd.Direction.HasValue)
            {
                writer.WriteStringValue(iItemFlowEnd.Direction.Value.ToString().ToLower());
            }
            else
            {
                writer.WriteNullValue();
            }

            writer.WritePropertyName("elementId");
            writer.WriteStringValue(iItemFlowEnd.ElementId);

            writer.WritePropertyName("isAbstract");
            writer.WriteBooleanValue(iItemFlowEnd.IsAbstract);

            writer.WritePropertyName("isComposite");
            writer.WriteBooleanValue(iItemFlowEnd.IsComposite);

            writer.WritePropertyName("isDerived");
            writer.WriteBooleanValue(iItemFlowEnd.IsDerived);

            writer.WritePropertyName("isEnd");
            writer.WriteBooleanValue(iItemFlowEnd.IsEnd);

            writer.WritePropertyName("isImpliedIncluded");
            writer.WriteBooleanValue(iItemFlowEnd.IsImpliedIncluded);

            writer.WritePropertyName("isOrdered");
            writer.WriteBooleanValue(iItemFlowEnd.IsOrdered);

            writer.WritePropertyName("isPortion");
            writer.WriteBooleanValue(iItemFlowEnd.IsPortion);

            writer.WritePropertyName("isReadOnly");
            writer.WriteBooleanValue(iItemFlowEnd.IsReadOnly);

            writer.WritePropertyName("isSufficient");
            writer.WriteBooleanValue(iItemFlowEnd.IsSufficient);

            writer.WritePropertyName("isUnique");
            writer.WriteBooleanValue(iItemFlowEnd.IsUnique);

            writer.WritePropertyName("name");
            writer.WriteStringValue(iItemFlowEnd.Name);

            writer.WriteStartArray("ownedRelationship");
            foreach (var item in iItemFlowEnd.OwnedRelationship)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();

            writer.WritePropertyName("owningRelationship");
            if (iItemFlowEnd.OwningRelationship.HasValue)
            {
                writer.WriteStringValue(iItemFlowEnd.OwningRelationship.Value);
            }
            else
            {
                writer.WriteNullValue();
            }

            writer.WritePropertyName("shortName");
            writer.WriteStringValue(iItemFlowEnd.ShortName);

            writer.WriteEndObject();
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
