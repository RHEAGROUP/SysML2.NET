﻿// -------------------------------------------------------------------------------------------------
// <copyright file="ISerializer.cs" company="RHEA System S.A.">
// 
//   Copyright 2022 RHEA System S.A.
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

namespace SysML2.NET.Serializer.Json
{
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json;
    using System.Threading;
    using System.Threading.Tasks;

    using SysML2.NET.DTO;

    /// <summary>
    /// The purpose of the <see cref="ISerializer"/> is to write an <see cref="IElement"/> and <see cref="IEnumerable{IElement}"/>
    /// as JSON to a <see cref="Stream"/>
    /// </summary>
    public interface ISerializer
    {
        /// <summary>
        /// Serialize an <see cref="IEnumerable{IElement}"/> as JSON to a target <see cref="Stream"/>
        /// </summary>
        /// <param name="elements">
        /// The <see cref="IEnumerable{IElement}"/> that shall be serialized
        /// </param>
        /// <param name="serializationModeKind">
        /// The <see cref="SerializationModeKind"/> to use
        /// </param>
        /// <param name="stream">
        /// The target <see cref="Stream"/>
        /// </param>
        /// <param name="jsonWriterOptions">
        /// The <see cref="JsonWriterOptions"/> to use
        /// </param>
        void Serialize(IEnumerable<IElement> elements, SerializationModeKind serializationModeKind, Stream stream, JsonWriterOptions jsonWriterOptions);

        /// <summary>
        /// Serialize an <see cref="IElement"/> as JSON to a target <see cref="Stream"/>
        /// </summary>
        /// <param name="element">
        /// The <see cref="IElement"/> that shall be serialized
        /// </param>
        /// <param name="serializationModeKind">
        /// The <see cref="SerializationModeKind"/> to use
        /// </param>
        /// <param name="stream">
        /// The target <see cref="Stream"/>
        /// </param>
        /// <param name="jsonWriterOptions">
        /// The <see cref="JsonWriterOptions"/> to use
        /// </param>
        void Serialize(IElement element, SerializationModeKind serializationModeKind, Stream stream, JsonWriterOptions jsonWriterOptions);

        /// <summary>
        /// Asynchronously serialize an <see cref="IEnumerable{IElement}"/> as JSON to a target <see cref="Stream"/>
        /// </summary>
        /// <param name="elements">
        /// The <see cref="IEnumerable{IElement}"/> that shall be serialized
        /// </param>
        /// <param name="serializationModeKind">
        /// The <see cref="SerializationModeKind"/> to use
        /// </param>
        /// <param name="stream">
        /// The target <see cref="Stream"/>
        /// </param>
        /// <param name="jsonWriterOptions">
        /// The <see cref="JsonWriterOptions"/> to use
        /// </param>
        Task SerializeAsync(IEnumerable<IElement> elements, SerializationModeKind serializationModeKind, Stream stream, JsonWriterOptions jsonWriterOptions, CancellationToken cancellationToken);

        /// <summary>
        /// Asynchronously serialize an <see cref="IElement"/> as JSON to a target <see cref="Stream"/>
        /// </summary>
        /// <param name="element">
        /// The <see cref="IElement"/> that shall be serialized
        /// </param>
        /// <param name="serializationModeKind">
        /// The <see cref="SerializationModeKind"/> to use
        /// </param>
        /// <param name="stream">
        /// The target <see cref="Stream"/>
        /// </param>
        /// <param name="jsonWriterOptions">
        /// The <see cref="JsonWriterOptions"/> to use
        /// </param>
        Task SerializeAsync(IElement element, SerializationModeKind serializationModeKind, Stream stream, JsonWriterOptions jsonWriterOptions, CancellationToken cancellationToken);
    }
}
