// -------------------------------------------------------------------------------------------------
// <copyright file="IAnnotatingElement.cs" company="RHEA System S.A.">
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

namespace SysML2.NET.DTO
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// An AnnotatingElement is an Element that provides additional description of or metadata on some other
    /// Element. An AnnotatingElement is attached to its annotatedElement by an Annotation
    /// Relationship.annotatedElement =  if annotation->notEmpty() then annotation.annotatedElement else
    /// owningNamespace endif
    /// </summary>
    public partial interface IAnnotatingElement : IElement
    {
        /// <summary>
        /// The Annotations that relate this AnnotatingElement to its annotatedElements.
        /// </summary>
        List<Guid> Annotation { get; set; }

    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------