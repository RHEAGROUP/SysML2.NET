// -------------------------------------------------------------------------------------------------
// <copyright file="Relationship.cs" company="RHEA System S.A.">
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

namespace SysML2.NET.DTO
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// A Relationship is an Element that relates two or more other Elements. Some of its relatedElements
    /// may be owned, in which case those ownedRelatedElements will be deleted from a model if their
    /// owningRelationship is. A Relationship may also be owned by another Element, in which case the
    /// ownedRelatedElements of the Relationship are also considered to be transitively owned by the
    /// owningRelatedElement of the Relationship.The relatedElements of a Relationship are divided into
    /// source and target Elements. The Relationship is considered to be directed from the source to the
    /// target Elements. An undirected Relationship may have either all source or all target Elements.A
    /// &quot;relationship Element&quot; in the kernel abstract syntax is generically any Element that is an
    /// instance of either Relationship or a direct or indirect specialization of Relationship. Any other
    /// kind of Element is a &quot;non-relationship Element&quot;. It is a convention of the kernel abstract
    /// syntax that non-relationship Elements are only related via reified relationship Elements. Any
    /// meta-associations directly between non-relationship Elements must be derived from underlying reified
    /// Relationships.
    /// </summary>
    public class Relationship : IElement
    {
        /// <summary>
        /// The relatedElements of this Relationship that are owned by the Relationship.
        /// </summary>
        public List<Guid> OwnedRelatedElement { get; set; }

        /// <summary>
        /// The relatedElement of this Relationship that owns the Relationship, if any.
        /// </summary>
        public Guid? OwningRelatedElement { get; set; }

        /// <summary>
        /// </summary>
        public List<Guid> Source { get; set; }

        /// <summary>
        /// </summary>
        public List<Guid> Target { get; set; }

        /// <summary>
        /// Various alternative identifiers for this Element. Generally, these will be set by tools.
        /// </summary>
        public List<string> AliasIds { get; set; }

        /// <summary>
        /// The globally unique identifier for this Element. This is intended to be set by tooling, and it must
        /// not change during the lifetime of the Element.
        /// </summary>
        public string ElementId { get; set; }

        /// <summary>
        /// The primary name of this Element.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The Relationships for which this Element is the owningRelatedElement.
        /// </summary>
        public List<Guid> OwnedRelationship { get; set; }

        /// <summary>
        /// The Relationship for which this Element is an ownedRelatedElement, if any.
        /// </summary>
        public Guid? OwningRelationship { get; set; }

        /// <summary>
        /// An optional alternative name for the Element that is intended to be shorter or in some way more
        /// succinct than its primary name. It may act as a modeler-specified identifier for the Element, though
        /// it is then the responsibility of the modeler to maintain the uniqueness of this identifier within a
        /// model or relative to some other context. 
        /// </summary>
        public string ShortName { get; set; }

    }
}
