﻿// -------------------------------------------------------------------------------------------------
// <copyright file="DataVersionSerializer.cs" company="RHEA System S.A.">
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
    /// The purpose of the <see cref="DataVersionSerializer"/> is to provide serialization capabilities
    /// </summary>
    internal static class DataVersionSerializer
    {
        /// <summary>
        /// Serializes an instance of <see cref="DataVersion"/> using an <see cref="Utf8JsonWriter"/>
        /// </summary>
        /// <param name="obj">
        /// The <see cref="DataVersion"/> to serialize
        /// </param>
        /// <param name="writer">
        /// The target <see cref="Utf8JsonWriter"/>
        /// </param>
        /// <param name="serializationModeKind">
        /// enumeration specifying what kind of serialization shall be used
        /// </param>
        internal static void Serialize(object obj, Utf8JsonWriter writer, SerializationModeKind serializationModeKind)
        {
            if (!(obj is DataVersion dataVersion))
            {
                throw new ArgumentException("The object shall be an DataVersion", nameof(obj));
            }

            switch (serializationModeKind)
            {
                case SerializationModeKind.JSON:

                    writer.WriteStartObject();
                    writer.WriteString("@type", "DataVersion");
                    writer.WriteString("@id", dataVersion.Id);
                    
                    //identity
                    //payload
                    
                    writer.WriteEndObject();

                    break;
                case SerializationModeKind.JSONLD:

                    throw new NotImplementedException();
            }
        }
    }
}