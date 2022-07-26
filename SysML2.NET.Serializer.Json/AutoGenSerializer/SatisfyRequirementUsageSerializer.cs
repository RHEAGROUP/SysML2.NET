// -------------------------------------------------------------------------------------------------
// <copyright file="SatisfyRequirementUsageSerializer.cs" company="RHEA System S.A.">
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
    /// The purpose of the <see cref="SatisfyRequirementUsageSerializer"/> is to provide serialization
    /// and deserialization capabilities
    /// </summary>
    internal static class SatisfyRequirementUsageSerializer
    {
        /// <summary>
        /// Serializes an instance of <see cref="ISatisfyRequirementUsage"/> using an <see cref="Utf8JsonWriter"/>
        /// </summary>
        /// <param name="obj">
        /// The <see cref="ISatisfyRequirementUsage"/> to serialize
        /// </param>
        /// <param name="writer">
        /// The target <see cref="Utf8JsonWriter"/>
        /// </param>
        /// <param name="serializationModeKind">
        /// enumeration specifying what kind of serialization shall be used
        /// </param>
        internal static void Serialize(object obj, Utf8JsonWriter writer, SerializationModeKind serializationModeKind)
        {
            if (!(obj is ISatisfyRequirementUsage iSatisfyRequirementUsage))
            {
                throw new ArgumentException("The object shall be an ISatisfyRequirementUsage", nameof(obj));
            }

            writer.WriteStartObject();

            writer.WritePropertyName("@type");
            writer.WriteStringValue("SatisfyRequirementUsage");

            writer.WritePropertyName("@id");
            writer.WriteStringValue(iSatisfyRequirementUsage.Id);

            writer.WriteStartArray("aliasIds");
            foreach (var item in iSatisfyRequirementUsage.AliasIds)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();

            writer.WritePropertyName("direction");
            if (iSatisfyRequirementUsage.Direction.HasValue)
            {
                writer.WriteStringValue(iSatisfyRequirementUsage.Direction.Value.ToString().ToLower());
            }
            else
            {
                writer.WriteNullValue();
            }

            writer.WritePropertyName("elementId");
            writer.WriteStringValue(iSatisfyRequirementUsage.ElementId);

            writer.WritePropertyName("isAbstract");
            writer.WriteBooleanValue(iSatisfyRequirementUsage.IsAbstract);

            writer.WritePropertyName("isComposite");
            writer.WriteBooleanValue(iSatisfyRequirementUsage.IsComposite);

            writer.WritePropertyName("isDerived");
            writer.WriteBooleanValue(iSatisfyRequirementUsage.IsDerived);

            writer.WritePropertyName("isEnd");
            writer.WriteBooleanValue(iSatisfyRequirementUsage.IsEnd);

            writer.WritePropertyName("isImpliedIncluded");
            writer.WriteBooleanValue(iSatisfyRequirementUsage.IsImpliedIncluded);

            writer.WritePropertyName("isIndividual");
            writer.WriteBooleanValue(iSatisfyRequirementUsage.IsIndividual);

            writer.WritePropertyName("isNegated");
            writer.WriteBooleanValue(iSatisfyRequirementUsage.IsNegated);

            writer.WritePropertyName("isOrdered");
            writer.WriteBooleanValue(iSatisfyRequirementUsage.IsOrdered);

            writer.WritePropertyName("isPortion");
            writer.WriteBooleanValue(iSatisfyRequirementUsage.IsPortion);

            writer.WritePropertyName("isReadOnly");
            writer.WriteBooleanValue(iSatisfyRequirementUsage.IsReadOnly);

            writer.WritePropertyName("isSufficient");
            writer.WriteBooleanValue(iSatisfyRequirementUsage.IsSufficient);

            writer.WritePropertyName("isUnique");
            writer.WriteBooleanValue(iSatisfyRequirementUsage.IsUnique);

            writer.WritePropertyName("isVariation");
            writer.WriteBooleanValue(iSatisfyRequirementUsage.IsVariation);

            writer.WritePropertyName("name");
            writer.WriteStringValue(iSatisfyRequirementUsage.Name);

            writer.WriteStartArray("ownedRelationship");
            foreach (var item in iSatisfyRequirementUsage.OwnedRelationship)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();

            writer.WritePropertyName("owningRelationship");
            if (iSatisfyRequirementUsage.OwningRelationship.HasValue)
            {
                writer.WriteStringValue(iSatisfyRequirementUsage.OwningRelationship.Value);
            }
            else
            {
                writer.WriteNullValue();
            }

            writer.WritePropertyName("portionKind");
            if (iSatisfyRequirementUsage.PortionKind.HasValue)
            {
                writer.WriteStringValue(iSatisfyRequirementUsage.PortionKind.Value.ToString().ToLower());
            }
            else
            {
                writer.WriteNullValue();
            }

            writer.WritePropertyName("reqId");
            writer.WriteStringValue(iSatisfyRequirementUsage.ReqId);

            writer.WritePropertyName("shortName");
            writer.WriteStringValue(iSatisfyRequirementUsage.ShortName);

            writer.WriteEndObject();
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
