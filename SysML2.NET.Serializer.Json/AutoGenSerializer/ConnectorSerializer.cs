// -------------------------------------------------------------------------------------------------
// <copyright file="ConnectorSerializer.cs" company="RHEA System S.A.">
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
    /// The purpose of the <see cref="ConnectorSerializer"/> is to provide serialization
    /// and deserialization capabilities
    /// </summary>
    internal static class ConnectorSerializer
    {
        /// <summary>
        /// Serializes an instance of <see cref="IConnector"/> using an <see cref="Utf8JsonWriter"/>
        /// </summary>
        /// <param name="obj">
        /// The <see cref="IConnector"/> to serialize
        /// </param>
        /// <param name="writer">
        /// The target <see cref="Utf8JsonWriter"/>
        /// </param>
        /// <param name="serializationModeKind">
        /// enumeration specifying what kind of serialization shall be used
        /// </param>
        internal static void Serialize(object obj, Utf8JsonWriter writer, SerializationModeKind serializationModeKind)
        {
            if (!(obj is IConnector iConnector))
            {
                throw new ArgumentException("The object shall be an IConnector", nameof(obj));
            }

            writer.WriteStartObject();

            writer.WritePropertyName("@type");
            writer.WriteStringValue("Connector");

            writer.WritePropertyName("@id");
            writer.WriteStringValue(iConnector.Id);

            writer.WriteStartArray("aliasIds");
            foreach (var item in iConnector.AliasIds)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();

            writer.WritePropertyName("direction");
            if (iConnector.Direction.HasValue)
            {
                writer.WriteStringValue(iConnector.Direction.Value.ToString().ToLower());
            }
            else
            {
                writer.WriteNullValue();
            }

            writer.WritePropertyName("elementId");
            writer.WriteStringValue(iConnector.ElementId);

            writer.WritePropertyName("isAbstract");
            writer.WriteBooleanValue(iConnector.IsAbstract);

            writer.WritePropertyName("isComposite");
            writer.WriteBooleanValue(iConnector.IsComposite);

            writer.WritePropertyName("isDerived");
            writer.WriteBooleanValue(iConnector.IsDerived);

            writer.WritePropertyName("isDirected");
            writer.WriteBooleanValue(iConnector.IsDirected);

            writer.WritePropertyName("isEnd");
            writer.WriteBooleanValue(iConnector.IsEnd);

            writer.WritePropertyName("isImplied");
            writer.WriteBooleanValue(iConnector.IsImplied);

            writer.WritePropertyName("isImpliedIncluded");
            writer.WriteBooleanValue(iConnector.IsImpliedIncluded);

            writer.WritePropertyName("isOrdered");
            writer.WriteBooleanValue(iConnector.IsOrdered);

            writer.WritePropertyName("isPortion");
            writer.WriteBooleanValue(iConnector.IsPortion);

            writer.WritePropertyName("isReadOnly");
            writer.WriteBooleanValue(iConnector.IsReadOnly);

            writer.WritePropertyName("isSufficient");
            writer.WriteBooleanValue(iConnector.IsSufficient);

            writer.WritePropertyName("isUnique");
            writer.WriteBooleanValue(iConnector.IsUnique);

            writer.WritePropertyName("name");
            writer.WriteStringValue(iConnector.Name);

            writer.WriteStartArray("ownedRelatedElement");
            foreach (var item in iConnector.OwnedRelatedElement)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();

            writer.WriteStartArray("ownedRelationship");
            foreach (var item in iConnector.OwnedRelationship)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();

            writer.WritePropertyName("owningRelatedElement");
            if (iConnector.OwningRelatedElement.HasValue)
            {
                writer.WriteStringValue(iConnector.OwningRelatedElement.Value);
            }
            else
            {
                writer.WriteNullValue();
            }

            writer.WritePropertyName("owningRelationship");
            if (iConnector.OwningRelationship.HasValue)
            {
                writer.WriteStringValue(iConnector.OwningRelationship.Value);
            }
            else
            {
                writer.WriteNullValue();
            }

            writer.WritePropertyName("shortName");
            writer.WriteStringValue(iConnector.ShortName);

            writer.WriteStartArray("source");
            foreach (var item in iConnector.Source)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();

            writer.WriteStartArray("target");
            foreach (var item in iConnector.Target)
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
