// -------------------------------------------------------------------------------------------------
// <copyright file="IElement.cs" company="RHEA System S.A.">
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

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------

namespace SysML2.NET.Core.DTO
{
    using System;
    using System.Collections.Generic;

    using SysML2.NET.Core;

    /// <summary>
    /// An Element is a constituent of a model that is uniquely identified relative to all other Elements.
    /// It can have Relationships with other Elements. Some of these Relationships might imply ownership of
    /// other Elements, which means that if an Element is deleted from a model, then so are all the Elements
    /// that it owns.ownedElement = ownedRelationship.ownedRelatedElementowner =
    /// owningRelationship.owningRelatedElementqualifiedName =    if owningNamespace = null then null   
    /// else if owningNamespace.owner = null then escapedName()    else if owningNamespace.qualifiedName =
    /// null then null    else owningNamespace.qualifiedName + '::' + escapedName()    endif endif
    /// endifdocumentation = ownedElement->selectByKind(Documentation)ownedAnnotation =
    /// ownedRelationship->selectByKind(Annotation)->    select(a | a.annotatedElement =
    /// self)effectiveName()ownedRelationship->exists(isImplied) implies isImpliedIncludedisLibraryElement =
    /// libraryNamespace() <>null
    /// </summary>
    public partial interface IElement
    {
        /// <summary>
        /// Various alternative identifiers for this Element. Generally, these will be set by tools.
        /// </summary>
        List<string> AliasIds { get; set; }

        /// <summary>
        /// The globally unique identifier for this Element. This is intended to be set by tooling, and it must
        /// not change during the lifetime of the Element.
        /// </summary>
        string ElementId { get; set; }

        /// <summary>
        /// Whether all necessary implied Relationships have been included in the ownedRelationships of this
        /// Element. This property may be true, even if there are not actually any ownedRelationships with
        /// isImplied = true, meaning that no such Relationships are actually implied for this Element. However,
        /// if it is false, then ownedRelationships may not contain any implied Relationships. That is, either
        /// all required implied Relationships must be included, or none of them.
        /// </summary>
        bool IsImpliedIncluded { get; set; }

        /// <summary>
        /// The primary name of this Element.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// The Relationships for which this Element is the owningRelatedElement.
        /// </summary>
        List<Guid> OwnedRelationship { get; set; }

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

    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
