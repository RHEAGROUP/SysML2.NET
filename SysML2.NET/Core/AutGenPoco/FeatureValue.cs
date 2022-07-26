// -------------------------------------------------------------------------------------------------
// <copyright file="FeatureValue.cs" company="RHEA System S.A.">
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

namespace SysML2.NET.Core.POCO
{
    using System;
    using System.Collections.Generic;

    using SysML2.NET.Core;

    /// <summary>
    /// A FeatureValue is a Membership that identifies a particular member Expression that provides the
    /// value of the Feature that owns the FeatureValue. The value is specified as either a bound value or
    /// an initial value, and as either a concrete or default value. A Feature can have at most one
    /// FeatureValue.The result of the value expression is bound to the featureWithValue using a
    /// BindingConnector. If isInitial = false, then the featuringType of the BindingConnector is the same
    /// as the featuringType of the featureWithValue. If isInitial = true, then the featuringType of the
    /// BindingConnector is restricted to its startShot.If isDefault = false, then the above semantics of
    /// the FeatureValue are realized for the given featureWithValue. Otherwise, the semantics are realized
    /// for any individual of the featuringType of the featureWithValue, unless another value is explicitly
    /// given for the featureWithValue for that individual.featureWithValue.ownedMember->   
    /// selectByKind(BindingConnector)->    exists(valueConnector |       
    /// valueConnector.relatedFeature->includes(featureWithValue) and       
    /// valueConnector.relatedFeature->includes(value.result) and        valueConnector.featuringType =
    /// featureWithValue.featuringType)
    /// </summary>
    public partial class FeatureValue : IFeatureValue
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureValue"/> class.
        /// </summary>
        public FeatureValue()
        {
            this.AliasIds = new List<string>();
            this.IsDefault = false;
            this.IsImplied = false;
            this.IsImpliedIncluded = false;
            this.IsInitial = false;
            this.OwnedRelatedElement = new List<Element>();
            this.OwnedRelationship = new List<Relationship>();
            this.Source = new List<Element>();
            this.Target = new List<Element>();
            this.Visibility = VisibilityKind.Public;
        }

        /// <summary>
        /// Gets or sets the unique identifier
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Various alternative identifiers for this Element. Generally, these will be set by tools.
        /// </summary>
        public List<string> AliasIds { get; set; }

        /// <summary>
        /// Queries the derived property Documentation
        /// </summary>
        public List<Documentation> QueryDocumentation()
        {
            throw new NotImplementedException("Derived property Documentation not yet supported");
        }

        /// <summary>
        /// Queries the derived property EffectiveName
        /// </summary>
        public string QueryEffectiveName()
        {
            throw new NotImplementedException("Derived property EffectiveName not yet supported");
        }

        /// <summary>
        /// The globally unique identifier for this Element. This is intended to be set by tooling, and it must
        /// not change during the lifetime of the Element.
        /// </summary>
        public string ElementId { get; set; }

        /// <summary>
        /// Queries the derived property FeatureWithValue
        /// </summary>
        public Feature QueryFeatureWithValue()
        {
            throw new NotImplementedException("Derived property FeatureWithValue not yet supported");
        }

        /// <summary>
        /// Whether this FeatureValue is a concrete specification of the bound of initial value of the
        /// featureWithValue, or just a default value that may be overridden.
        /// </summary>
        public bool IsDefault { get; set; }

        /// <summary>
        /// Whether this Relationship was generated by tooling to meet semantic rules, rather than being
        /// directly created by a modeler.
        /// </summary>
        public bool IsImplied { get; set; }

        /// <summary>
        /// Whether all necessary implied Relationships have been included in the ownedRelationships of this
        /// Element. This property may be true, even if there are not actually any ownedRelationships with
        /// isImplied = true, meaning that no such Relationships are actually implied for this Element. However,
        /// if it is false, then ownedRelationships may not contain any implied Relationships. That is, either
        /// all required implied Relationships must be included, or none of them.
        /// </summary>
        public bool IsImpliedIncluded { get; set; }

        /// <summary>
        /// Whether this FeatureValue specifies a bound value or an initial value for the featureWithValue.
        /// </summary>
        public bool IsInitial { get; set; }

        /// <summary>
        /// Queries the derived property IsLibraryElement
        /// </summary>
        public bool QueryIsLibraryElement()
        {
            throw new NotImplementedException("Derived property IsLibraryElement not yet supported");
        }

        /// <summary>
        /// </summary>
        public Element MemberElement { get; set; }

        /// <summary>
        /// Queries the derived property MemberElementId
        /// </summary>
        public string QueryMemberElementId()
        {
            throw new NotImplementedException("Derived property MemberElementId not yet supported");
        }

        /// <summary>
        /// The name of the memberElement relative to the membershipOwningNamespace.
        /// </summary>
        public string MemberName { get; set; }

        /// <summary>
        /// Queries the derived property MembershipOwningNamespace
        /// </summary>
        public Namespace QueryMembershipOwningNamespace()
        {
            throw new NotImplementedException("Derived property MembershipOwningNamespace not yet supported");
        }

        /// <summary>
        /// The short name of the memberElement relative to the membershipOwningNamespace.
        /// </summary>
        public string MemberShortName { get; set; }

        /// <summary>
        /// The primary name of this Element.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Queries the derived property OwnedAnnotation
        /// </summary>
        public List<Annotation> QueryOwnedAnnotation()
        {
            throw new NotImplementedException("Derived property OwnedAnnotation not yet supported");
        }

        /// <summary>
        /// Queries the derived property OwnedElement
        /// </summary>
        public List<Element> QueryOwnedElement()
        {
            throw new NotImplementedException("Derived property OwnedElement not yet supported");
        }

        /// <summary>
        /// Queries the derived property OwnedMemberElement
        /// </summary>
        public Element QueryOwnedMemberElement()
        {
            throw new NotImplementedException("Derived property OwnedMemberElement not yet supported");
        }

        /// <summary>
        /// Queries the derived property OwnedMemberElementId
        /// </summary>
        public string QueryOwnedMemberElementId()
        {
            throw new NotImplementedException("Derived property OwnedMemberElementId not yet supported");
        }

        /// <summary>
        /// Queries the derived property OwnedMemberName
        /// </summary>
        public string QueryOwnedMemberName()
        {
            throw new NotImplementedException("Derived property OwnedMemberName not yet supported");
        }

        /// <summary>
        /// Queries the derived property OwnedMemberShortName
        /// </summary>
        public string QueryOwnedMemberShortName()
        {
            throw new NotImplementedException("Derived property OwnedMemberShortName not yet supported");
        }

        /// <summary>
        /// The relatedElements of this Relationship that are owned by the Relationship.
        /// </summary>
        public List<Element> OwnedRelatedElement { get; set; }

        /// <summary>
        /// The Relationships for which this Element is the owningRelatedElement.
        /// </summary>
        public List<Relationship> OwnedRelationship { get; set; }

        /// <summary>
        /// Queries the derived property Owner
        /// </summary>
        public Element QueryOwner()
        {
            throw new NotImplementedException("Derived property Owner not yet supported");
        }

        /// <summary>
        /// Queries the derived property OwningMembership
        /// </summary>
        public OwningMembership QueryOwningMembership()
        {
            throw new NotImplementedException("Derived property OwningMembership not yet supported");
        }

        /// <summary>
        /// Queries the derived property OwningNamespace
        /// </summary>
        public Namespace QueryOwningNamespace()
        {
            throw new NotImplementedException("Derived property OwningNamespace not yet supported");
        }

        /// <summary>
        /// The relatedElement of this Relationship that owns the Relationship, if any.
        /// </summary>
        public Element OwningRelatedElement { get; set; }

        /// <summary>
        /// The Relationship for which this Element is an ownedRelatedElement, if any.
        /// </summary>
        public Relationship OwningRelationship { get; set; }

        /// <summary>
        /// Queries the derived property QualifiedName
        /// </summary>
        public string QueryQualifiedName()
        {
            throw new NotImplementedException("Derived property QualifiedName not yet supported");
        }

        /// <summary>
        /// Queries the derived property RelatedElement
        /// </summary>
        public List<Element> QueryRelatedElement()
        {
            throw new NotImplementedException("Derived property RelatedElement not yet supported");
        }

        /// <summary>
        /// An optional alternative name for the Element that is intended to be shorter or in some way more
        /// succinct than its primary name. It may act as a modeler-specified identifier for the Element, though
        /// it is then the responsibility of the modeler to maintain the uniqueness of this identifier within a
        /// model or relative to some other context.
        /// </summary>
        public string ShortName { get; set; }

        /// <summary>
        /// </summary>
        public List<Element> Source { get; set; }

        /// <summary>
        /// </summary>
        public List<Element> Target { get; set; }

        /// <summary>
        /// Queries the derived property TextualRepresentation
        /// </summary>
        public List<TextualRepresentation> QueryTextualRepresentation()
        {
            throw new NotImplementedException("Derived property TextualRepresentation not yet supported");
        }

        /// <summary>
        /// Queries the derived property Value
        /// </summary>
        public Expression QueryValue()
        {
            throw new NotImplementedException("Derived property Value not yet supported");
        }

        /// <summary>
        /// Whether or not the Membership of the memberElement in the membershipOwningNamespace is publicly
        /// visible outside that Namespace.
        /// </summary>
        public VisibilityKind Visibility { get; set; }

    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
