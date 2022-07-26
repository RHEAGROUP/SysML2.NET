// -------------------------------------------------------------------------------------------------
// <copyright file="ElementFilterMembershipSerializer.cs" company="RHEA System S.A.">
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
    /// The purpose of the <see cref="ElementFilterMembershipSerializer"/> is to provide serialization
    /// and deserialization capabilities
    /// </summary>
    internal static class ElementFilterMembershipSerializer
    {
        /// <summary>
        /// Serializes an instance of <see cref="IElementFilterMembership"/> using an <see cref="Utf8JsonWriter"/>
        /// </summary>
        /// <param name="obj">
        /// The <see cref="IElementFilterMembership"/> to serialize
        /// </param>
        /// <param name="writer">
        /// The target <see cref="Utf8JsonWriter"/>
        /// </param>
        /// <param name="serializationModeKind">
        /// enumeration specifying what kind of serialization shall be used
        /// </param>
        internal static void Serialize(object obj, Utf8JsonWriter writer, SerializationModeKind serializationModeKind)
        {
            if (!(obj is IElementFilterMembership iElementFilterMembership))
            {
                throw new ArgumentException("The object shall be an IElementFilterMembership", nameof(obj));
            }

            writer.WriteStartObject();

            writer.WritePropertyName("@type");
            writer.WriteStringValue("ElementFilterMembership");

            writer.WritePropertyName("@id");
            writer.WriteStringValue(iElementFilterMembership.Id);

            writer.WriteStartArray("aliasIds");
            foreach (var item in iElementFilterMembership.AliasIds)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();

            writer.WritePropertyName("elementId");
            writer.WriteStringValue(iElementFilterMembership.ElementId);

            writer.WritePropertyName("isImplied");
            writer.WriteBooleanValue(iElementFilterMembership.IsImplied);

            writer.WritePropertyName("isImpliedIncluded");
            writer.WriteBooleanValue(iElementFilterMembership.IsImpliedIncluded);

            writer.WritePropertyName("memberElement");
            writer.WriteStringValue(iElementFilterMembership.MemberElement);

            writer.WritePropertyName("memberName");
            writer.WriteStringValue(iElementFilterMembership.MemberName);

            writer.WritePropertyName("memberShortName");
            writer.WriteStringValue(iElementFilterMembership.MemberShortName);

            writer.WritePropertyName("name");
            writer.WriteStringValue(iElementFilterMembership.Name);

            writer.WriteStartArray("ownedRelatedElement");
            foreach (var item in iElementFilterMembership.OwnedRelatedElement)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();

            writer.WriteStartArray("ownedRelationship");
            foreach (var item in iElementFilterMembership.OwnedRelationship)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();

            writer.WritePropertyName("owningRelatedElement");
            if (iElementFilterMembership.OwningRelatedElement.HasValue)
            {
                writer.WriteStringValue(iElementFilterMembership.OwningRelatedElement.Value);
            }
            else
            {
                writer.WriteNullValue();
            }

            writer.WritePropertyName("owningRelationship");
            if (iElementFilterMembership.OwningRelationship.HasValue)
            {
                writer.WriteStringValue(iElementFilterMembership.OwningRelationship.Value);
            }
            else
            {
                writer.WriteNullValue();
            }

            writer.WritePropertyName("shortName");
            writer.WriteStringValue(iElementFilterMembership.ShortName);

            writer.WriteStartArray("source");
            foreach (var item in iElementFilterMembership.Source)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();

            writer.WriteStartArray("target");
            foreach (var item in iElementFilterMembership.Target)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();

            writer.WritePropertyName("visibility");
            writer.WriteStringValue(iElementFilterMembership.Visibility.ToString().ToLower());

            writer.WriteEndObject();
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
