// -------------------------------------------------------------------------------------------------
// <copyright file="IDependency.cs" company="RHEA System S.A.">
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
    /// A Dependency is a Relationship that indicates that one or more client Elements require one more
    /// supplier Elements for their complete specification. In general, this means that a change to one of
    /// the supplier Elements may necessitate a change to, or re-specification of, the client Elements.Note
    /// that a Dependency is entirely a model-level Relationship, without instance-level semantics.
    /// </summary>
    public partial interface IDependency : IRelationship
    {
        /// <summary>
        /// Various alternative identifiers for this Element. Generally, these will be set by tools.
        /// </summary>
        List<string> AliasIds { get; set; }

        /// <summary>
        /// </summary>
        List<Guid> Client { get; set; }

        /// <summary>
        /// The globally unique identifier for this Element. This is intended to be set by tooling, and it must
        /// not change during the lifetime of the Element.
        /// </summary>
        string ElementId { get; set; }

        /// <summary>
        /// The primary name of this Element.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// The relatedElements of this Relationship that are owned by the Relationship.
        /// </summary>
        List<Guid> OwnedRelatedElement { get; set; }

        /// <summary>
        /// The Relationships for which this Element is the owningRelatedElement.
        /// </summary>
        List<Guid> OwnedRelationship { get; set; }

        /// <summary>
        /// The relatedElement of this Relationship that owns the Relationship, if any.
        /// </summary>
        Guid? OwningRelatedElement { get; set; }

        /// <summary>
        /// The Relationship for which this Element is an ownedRelatedElement, if any.
        /// </summary>
        Guid? OwningRelationship { get; set; }

        /// <summary>
        /// An optional alternative name for the Element that is intended to be shorter or in some way more
        /// succinct than its primary name. It may act as a modeler-specified identifier for the Element, though
        /// it is then the responsibility of the modeler to maintain the uniqueness of this identifier within a
        /// model or relative to some other context. 
        /// </summary>
        string ShortName { get; set; }

        /// <summary>
        /// </summary>
        List<Guid> Source { get; set; }

        /// <summary>
        /// </summary>
        List<Guid> Supplier { get; set; }

        /// <summary>
        /// </summary>
        List<Guid> Target { get; set; }

    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
