﻿// -------------------------------------------------------------------------------------------------
// <copyright file="TagSerializer.cs" company="RHEA System S.A.">
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

namespace SysML2.NET.Serializer.Json.PIM
{
    using System;
    using System.Text.Json;

    using SysML2.NET.PIM.DTO;

    /// <summary>
    /// The purpose of the <see cref="TagSerializer"/> is to provide serialization capabilities
    /// </summary>
    internal static class TagSerializer
    {
        /// <summary>
        /// Serializes an instance of <see cref="Tag"/> using an <see cref="Utf8JsonWriter"/>
        /// </summary>
        /// <param name="obj">
        /// The <see cref="Tag"/> to serialize
        /// </param>
        /// <param name="writer">
        /// The target <see cref="Utf8JsonWriter"/>
        /// </param>
        /// <param name="serializationModeKind">
        /// enumeration specifying what kind of serialization shall be used
        /// </param>
        internal static void Serialize(object obj, Utf8JsonWriter writer, SerializationModeKind serializationModeKind)
        {
            if (!(obj is Tag tag))
            {
                throw new ArgumentException("The object shall be an Tag", nameof(obj));
            }

            switch (serializationModeKind)
            {
                case SerializationModeKind.JSON:

                    writer.WriteStartObject();
                    writer.WriteString("@type", "Tag");
                    writer.WriteString("@id", tag.Id);

                    writer.WriteString("description", tag.Description);
                    writer.WriteString("name", tag.Name);
                    writer.WriteStartObject("owningProject");
                    writer.WriteString("@id", tag.OwningProject);
                    writer.WriteEndObject();
                    writer.WriteStartObject("referencedCommit");
                    writer.WriteString("@id", tag.ReferencedCommit);
                    writer.WriteEndObject();
                    writer.WriteStartObject("taggedCommit");
                    writer.WriteString("@id", tag.TaggedCommit);
                    writer.WriteEndObject();
                    writer.WriteString("timestamp", tag.TimeStamp);
                    writer.WriteEndObject();

                    break;
                case SerializationModeKind.JSONLD:

                    throw new NotImplementedException();
            }
        }
    }
}