﻿// -------------------------------------------------------------------------------------------------
// <copyright file="SuccessionItemFlow.cs" company="RHEA System S.A.">
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

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------

namespace SysML2.NET.Core.POCO
{
    using System;
    using System.Collections.Generic;

    using SysML2.NET.Core;
    using SysML2.NET.Decorators;

    /// <summary>
    /// A SuccessionItemFlow is an ItemFlow that also provides temporal ordering. It classifies Transfers
    /// that cannot start until the source Occurrence has completed and that must complete before the target
    /// Occurrence can start.A SuccessionItemFlow must be typed by the Interaction TransferBefore from the
    /// Kernel Library, or a specialization of it.SuccessionItemFlows are ItemFlows that also provide
    /// temporal ordering. They classify Transfers that must complete before the target behavior can
    /// start.Must be typed by M1 TransferBefore or one of its
    /// specializations.<br>association-&gt;is=OrSpecializationOf(TransferBefore) }
    /// </summary>
    public partial class SuccessionItemFlow : ISuccessionItemFlow
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SuccessionItemFlow"/> class.
        /// </summary>
        public SuccessionItemFlow()
        {
            this.AliasIds = new List<string>();
            this.IsAbstract = false;
            this.IsComposite = false;
            this.IsDerived = false;
            this.IsDirected = false;
            this.IsEnd = false;
            this.IsImplied = false;
            this.IsImpliedIncluded = false;
            this.IsOrdered = false;
            this.IsPortion = false;
            this.IsReadOnly = false;
            this.IsSufficient = false;
            this.IsUnique = true;
            this.OwnedRelatedElement = new List<Element>();
            this.OwnedRelationship = new List<Relationship>();
            this.Source = new List<Element>();
            this.Target = new List<Element>();
        }

        /// <summary>
        /// Gets or sets the unique identifier
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: false, isTransient: false, isUnsettable: false, isDerived: false, isOrdered: true, isUnique: true, lowerBound: 1, upperBound: 1, isMany: false, isRequired: false, isContainment: false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Various alternative identifiers for this Element. Generally, these will be set by tools.
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: false, isTransient: false, isUnsettable: false, isDerived: false, isOrdered: true, isUnique: true, lowerBound: 0, upperBound: -1, isMany: false, isRequired: false, isContainment: false)]
        public List<string> AliasIds { get; set; }

        /// <summary>
        /// Queries the derived property Association
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: true, isUnique: true, lowerBound: 1, upperBound: -1, isMany: false, isRequired: false, isContainment: false)]
        public List<Association> QueryAssociation()
        {
            throw new NotImplementedException("Derived property Association not yet supported");
        }

        /// <summary>
        /// Queries the derived property Behavior
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: true, isUnique: true, lowerBound: 1, upperBound: -1, isMany: false, isRequired: false, isContainment: false)]
        public List<Behavior> QueryBehavior()
        {
            throw new NotImplementedException("Derived property Behavior not yet supported");
        }

        /// <summary>
        /// Queries the derived property ChainingFeature
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: true, isUnique: false, lowerBound: 0, upperBound: -1, isMany: false, isRequired: false, isContainment: false)]
        public List<Feature> QueryChainingFeature()
        {
            throw new NotImplementedException("Derived property ChainingFeature not yet supported");
        }

        /// <summary>
        /// Queries the derived property ConnectorEnd
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: true, isUnique: true, lowerBound: 2, upperBound: -1, isMany: false, isRequired: false, isContainment: false)]
        public List<Feature> QueryConnectorEnd()
        {
            throw new NotImplementedException("Derived property ConnectorEnd not yet supported");
        }

        /// <summary>
        /// Queries the derived property DifferencingType
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: true, isUnique: true, lowerBound: 0, upperBound: -1, isMany: false, isRequired: false, isContainment: false)]
        public List<Type> QueryDifferencingType()
        {
            throw new NotImplementedException("Derived property DifferencingType not yet supported");
        }

        /// <summary>
        /// Queries the derived property DirectedFeature
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: true, isUnique: true, lowerBound: 0, upperBound: -1, isMany: false, isRequired: false, isContainment: false)]
        public List<Feature> QueryDirectedFeature()
        {
            throw new NotImplementedException("Derived property DirectedFeature not yet supported");
        }

        /// <summary>
        /// Determines how values of this Feature are determined or used (see FeatureDirectionKind).
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: false, isTransient: false, isUnsettable: false, isDerived: false, isOrdered: false, isUnique: true, lowerBound: 0, upperBound: 1, isMany: false, isRequired: false, isContainment: false)]
        public FeatureDirectionKind? Direction { get; set; }

        /// <summary>
        /// Queries the derived property Documentation
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: true, isUnique: true, lowerBound: 0, upperBound: -1, isMany: false, isRequired: false, isContainment: false)]
        public List<Documentation> QueryDocumentation()
        {
            throw new NotImplementedException("Derived property Documentation not yet supported");
        }

        /// <summary>
        /// Queries the derived property EffectiveName
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: false, isUnique: true, lowerBound: 0, upperBound: 1, isMany: false, isRequired: false, isContainment: false)]
        public string QueryEffectiveName()
        {
            throw new NotImplementedException("Derived property EffectiveName not yet supported");
        }

        /// <summary>
        /// Queries the derived property EffectStep
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: false, isUnique: true, lowerBound: 0, upperBound: -1, isMany: false, isRequired: false, isContainment: false)]
        public List<Step> QueryEffectStep()
        {
            throw new NotImplementedException("Derived property EffectStep not yet supported");
        }

        /// <summary>
        /// The globally unique identifier for this Element. This is intended to be set by tooling, and it must
        /// not change during the lifetime of the Element.
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: false, isTransient: false, isUnsettable: false, isDerived: false, isOrdered: false, isUnique: true, lowerBound: 1, upperBound: 1, isMany: false, isRequired: false, isContainment: false)]
        public string ElementId { get; set; }

        /// <summary>
        /// Queries the derived property EndFeature
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: true, isUnique: true, lowerBound: 0, upperBound: -1, isMany: false, isRequired: false, isContainment: false)]
        public List<Feature> QueryEndFeature()
        {
            throw new NotImplementedException("Derived property EndFeature not yet supported");
        }

        /// <summary>
        /// Queries the derived property EndOwningType
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: false, isUnique: true, lowerBound: 0, upperBound: 1, isMany: false, isRequired: false, isContainment: false)]
        public Type QueryEndOwningType()
        {
            throw new NotImplementedException("Derived property EndOwningType not yet supported");
        }

        /// <summary>
        /// Queries the derived property Feature
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: true, isUnique: true, lowerBound: 0, upperBound: -1, isMany: false, isRequired: false, isContainment: false)]
        public List<Feature> QueryFeature()
        {
            throw new NotImplementedException("Derived property Feature not yet supported");
        }

        /// <summary>
        /// Queries the derived property FeatureMembership
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: true, isUnique: true, lowerBound: 0, upperBound: -1, isMany: false, isRequired: false, isContainment: false)]
        public List<FeatureMembership> QueryFeatureMembership()
        {
            throw new NotImplementedException("Derived property FeatureMembership not yet supported");
        }

        /// <summary>
        /// Queries the derived property FeaturingType
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: true, isUnique: true, lowerBound: 0, upperBound: -1, isMany: false, isRequired: false, isContainment: false)]
        public List<Type> QueryFeaturingType()
        {
            throw new NotImplementedException("Derived property FeaturingType not yet supported");
        }

        /// <summary>
        /// Queries the derived property GuardExpression
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: false, isUnique: true, lowerBound: 0, upperBound: -1, isMany: false, isRequired: false, isContainment: false)]
        public List<Expression> QueryGuardExpression()
        {
            throw new NotImplementedException("Derived property GuardExpression not yet supported");
        }

        /// <summary>
        /// Queries the derived property ImportedMembership
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: true, isUnique: true, lowerBound: 0, upperBound: -1, isMany: false, isRequired: false, isContainment: false)]
        public List<Membership> QueryImportedMembership()
        {
            throw new NotImplementedException("Derived property ImportedMembership not yet supported");
        }

        /// <summary>
        /// Queries the derived property InheritedFeature
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: true, isUnique: true, lowerBound: 0, upperBound: -1, isMany: false, isRequired: false, isContainment: false)]
        public List<Feature> QueryInheritedFeature()
        {
            throw new NotImplementedException("Derived property InheritedFeature not yet supported");
        }

        /// <summary>
        /// Queries the derived property InheritedMembership
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: true, isUnique: true, lowerBound: 0, upperBound: -1, isMany: false, isRequired: false, isContainment: false)]
        public List<Membership> QueryInheritedMembership()
        {
            throw new NotImplementedException("Derived property InheritedMembership not yet supported");
        }

        /// <summary>
        /// Queries the derived property Input
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: true, isUnique: true, lowerBound: 0, upperBound: -1, isMany: false, isRequired: false, isContainment: false)]
        public List<Feature> QueryInput()
        {
            throw new NotImplementedException("Derived property Input not yet supported");
        }

        /// <summary>
        /// Queries the derived property Interaction
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: true, isUnique: true, lowerBound: 1, upperBound: -1, isMany: false, isRequired: false, isContainment: false)]
        public List<Interaction> QueryInteraction()
        {
            throw new NotImplementedException("Derived property Interaction not yet supported");
        }

        /// <summary>
        /// Queries the derived property IntersectingType
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: true, isUnique: true, lowerBound: 0, upperBound: -1, isMany: false, isRequired: false, isContainment: false)]
        public List<Type> QueryIntersectingType()
        {
            throw new NotImplementedException("Derived property IntersectingType not yet supported");
        }

        /// <summary>
        /// Indicates whether instances of this Type must also be instances of at least one of its specialized
        /// Types.
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: false, isTransient: false, isUnsettable: false, isDerived: false, isOrdered: false, isUnique: true, lowerBound: 1, upperBound: 1, isMany: false, isRequired: false, isContainment: false)]
        public bool IsAbstract { get; set; }

        /// <summary>
        /// Whether the Feature is a composite feature of its featuringType. If so, the values of the Feature
        /// cannot exist after the instance of the featuringType no longer does..
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: false, isTransient: false, isUnsettable: false, isDerived: false, isOrdered: false, isUnique: true, lowerBound: 1, upperBound: 1, isMany: false, isRequired: false, isContainment: false)]
        public bool IsComposite { get; set; }

        /// <summary>
        /// Queries the derived property IsConjugated
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: false, isUnique: true, lowerBound: 1, upperBound: 1, isMany: false, isRequired: false, isContainment: false)]
        public bool QueryIsConjugated()
        {
            throw new NotImplementedException("Derived property IsConjugated not yet supported");
        }

        /// <summary>
        /// Whether the values of this Feature can always be computed from the values of other Features.
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: false, isTransient: false, isUnsettable: false, isDerived: false, isOrdered: false, isUnique: true, lowerBound: 1, upperBound: 1, isMany: false, isRequired: false, isContainment: false)]
        public bool IsDerived { get; set; }

        /// <summary>
        /// For a binary Connector, whether or not the Connector should be considered to have a direction from
        /// source to target.
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: false, isTransient: false, isUnsettable: false, isDerived: false, isOrdered: false, isUnique: true, lowerBound: 1, upperBound: 1, isMany: false, isRequired: false, isContainment: false)]
        public bool IsDirected { get; set; }

        /// <summary>
        /// Whether or not the this Feature is an end Feature, requiring a different interpretation of the
        /// multiplicity of the Feature.An end Feature is always considered to map each domain entity to a
        /// single co-domain entity, whether or not a Multiplicity is given for it. If a Multiplicity is given
        /// for an end Feature, rather than giving the co-domain cardinality for the Feature as usual, it
        /// specifies a cardinality constraint for navigating across the endFeatures of the featuringType of the
        /// end Feature. That is, if a Type has n endFeatures, then the Multiplicity of any one of those end
        /// Features constrains the cardinality of the set of values of that Feature when the values of the
        /// other n-1 end Features are held fixed.
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: false, isTransient: false, isUnsettable: false, isDerived: false, isOrdered: false, isUnique: true, lowerBound: 1, upperBound: 1, isMany: false, isRequired: false, isContainment: false)]
        public bool IsEnd { get; set; }

        /// <summary>
        /// Whether this Relationship was generated by tooling to meet semantic rules, rather than being
        /// directly created by a modeler.
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: false, isTransient: false, isUnsettable: false, isDerived: false, isOrdered: false, isUnique: true, lowerBound: 1, upperBound: 1, isMany: false, isRequired: false, isContainment: false)]
        public bool IsImplied { get; set; }

        /// <summary>
        /// Whether all necessary implied Relationships have been included in the ownedRelationships of this
        /// Element. This property may be true, even if there are not actually any ownedRelationships with
        /// isImplied = true, meaning that no such Relationships are actually implied for this Element. However,
        /// if it is false, then ownedRelationships may not contain any implied Relationships. That is, either
        /// all required implied Relationships must be included, or none of them.
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: false, isTransient: false, isUnsettable: false, isDerived: false, isOrdered: false, isUnique: true, lowerBound: 1, upperBound: 1, isMany: false, isRequired: false, isContainment: false)]
        public bool IsImpliedIncluded { get; set; }

        /// <summary>
        /// Queries the derived property IsLibraryElement
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: false, isUnique: true, lowerBound: 1, upperBound: 1, isMany: false, isRequired: false, isContainment: false)]
        public bool QueryIsLibraryElement()
        {
            throw new NotImplementedException("Derived property IsLibraryElement not yet supported");
        }

        /// <summary>
        /// Queries the derived property IsNonunique
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: false, isUnique: true, lowerBound: 1, upperBound: 1, isMany: false, isRequired: false, isContainment: false)]
        public bool QueryIsNonunique()
        {
            throw new NotImplementedException("Derived property IsNonunique not yet supported");
        }

        /// <summary>
        /// Whether an order exists for the values of this Feature or not.
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: false, isTransient: false, isUnsettable: false, isDerived: false, isOrdered: false, isUnique: true, lowerBound: 1, upperBound: 1, isMany: false, isRequired: false, isContainment: false)]
        public bool IsOrdered { get; set; }

        /// <summary>
        /// Whether the values of this Feature are contained in the space and time of instances of the
        /// Feature&#39;s domain.
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: false, isTransient: false, isUnsettable: false, isDerived: false, isOrdered: false, isUnique: true, lowerBound: 1, upperBound: 1, isMany: false, isRequired: false, isContainment: false)]
        public bool IsPortion { get; set; }

        /// <summary>
        /// Whether the values of this Feature can change over the lifetime of an instance of the domain.
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: false, isTransient: false, isUnsettable: false, isDerived: false, isOrdered: false, isUnique: true, lowerBound: 1, upperBound: 1, isMany: false, isRequired: false, isContainment: false)]
        public bool IsReadOnly { get; set; }

        /// <summary>
        /// Whether all things that meet the classification conditions of this Type must be classified by the
        /// Type.(A Type gives conditions that must be met by whatever it classifies, but when isSufficient
        /// is false, things may meet those conditions but still not be classified by the Type. For example, a
        /// Type Car that is not sufficient could require everything it classifies to have four wheels, but not
        /// all four wheeled things would need to be cars. However, if the type Car were sufficient, it would
        /// classify all four-wheeled things.)
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: false, isTransient: false, isUnsettable: false, isDerived: false, isOrdered: false, isUnique: true, lowerBound: 1, upperBound: 1, isMany: false, isRequired: false, isContainment: false)]
        public bool IsSufficient { get; set; }

        /// <summary>
        /// Whether or not values for this Feature must have no duplicates or not.
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: false, isTransient: false, isUnsettable: false, isDerived: false, isOrdered: false, isUnique: true, lowerBound: 1, upperBound: 1, isMany: false, isRequired: false, isContainment: false)]
        public bool IsUnique { get; set; }

        /// <summary>
        /// Queries the derived property ItemFeature
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: false, isUnique: true, lowerBound: 0, upperBound: 1, isMany: false, isRequired: false, isContainment: false)]
        public ItemFeature QueryItemFeature()
        {
            throw new NotImplementedException("Derived property ItemFeature not yet supported");
        }

        /// <summary>
        /// Queries the derived property ItemFlowEnd
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: false, isUnique: true, lowerBound: 2, upperBound: -1, isMany: false, isRequired: false, isContainment: false)]
        public List<ItemFlowEnd> QueryItemFlowEnd()
        {
            throw new NotImplementedException("Derived property ItemFlowEnd not yet supported");
        }

        /// <summary>
        /// Queries the derived property ItemFlowFeature
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: false, isUnique: true, lowerBound: 2, upperBound: -1, isMany: false, isRequired: false, isContainment: false)]
        public List<ItemFlowFeature> QueryItemFlowFeature()
        {
            throw new NotImplementedException("Derived property ItemFlowFeature not yet supported");
        }

        /// <summary>
        /// Queries the derived property ItemType
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: true, isUnique: false, lowerBound: 0, upperBound: -1, isMany: false, isRequired: false, isContainment: false)]
        public List<Classifier> QueryItemType()
        {
            throw new NotImplementedException("Derived property ItemType not yet supported");
        }

        /// <summary>
        /// Queries the derived property Member
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: true, isUnique: true, lowerBound: 0, upperBound: -1, isMany: false, isRequired: false, isContainment: false)]
        public List<Element> QueryMember()
        {
            throw new NotImplementedException("Derived property Member not yet supported");
        }

        /// <summary>
        /// Queries the derived property Membership
        /// </summary>
        [EFeature(isChangeable: false, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: true, isUnique: true, lowerBound: 0, upperBound: -1, isMany: false, isRequired: false, isContainment: false)]
        public List<Membership> QueryMembership()
        {
            throw new NotImplementedException("Derived property Membership not yet supported");
        }

        /// <summary>
        /// Queries the derived property Multiplicity
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: false, isUnique: true, lowerBound: 0, upperBound: 1, isMany: false, isRequired: false, isContainment: false)]
        public Multiplicity QueryMultiplicity()
        {
            throw new NotImplementedException("Derived property Multiplicity not yet supported");
        }

        /// <summary>
        /// The primary name of this Element.
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: false, isTransient: false, isUnsettable: false, isDerived: false, isOrdered: false, isUnique: true, lowerBound: 0, upperBound: 1, isMany: false, isRequired: false, isContainment: false)]
        public string Name { get; set; }

        /// <summary>
        /// Queries the derived property Output
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: true, isUnique: true, lowerBound: 0, upperBound: -1, isMany: false, isRequired: false, isContainment: false)]
        public List<Feature> QueryOutput()
        {
            throw new NotImplementedException("Derived property Output not yet supported");
        }

        /// <summary>
        /// Queries the derived property OwnedAnnotation
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: true, isUnique: true, lowerBound: 0, upperBound: -1, isMany: false, isRequired: false, isContainment: false)]
        public List<Annotation> QueryOwnedAnnotation()
        {
            throw new NotImplementedException("Derived property OwnedAnnotation not yet supported");
        }

        /// <summary>
        /// Queries the derived property OwnedConjugator
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: false, isUnique: true, lowerBound: 0, upperBound: 1, isMany: false, isRequired: false, isContainment: false)]
        public Conjugation QueryOwnedConjugator()
        {
            throw new NotImplementedException("Derived property OwnedConjugator not yet supported");
        }

        /// <summary>
        /// Queries the derived property OwnedDifferencing
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: true, isUnique: true, lowerBound: 0, upperBound: -1, isMany: false, isRequired: false, isContainment: false)]
        public List<Differencing> QueryOwnedDifferencing()
        {
            throw new NotImplementedException("Derived property OwnedDifferencing not yet supported");
        }

        /// <summary>
        /// Queries the derived property OwnedDisjoining
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: false, isUnique: true, lowerBound: 0, upperBound: -1, isMany: false, isRequired: false, isContainment: false)]
        public List<Disjoining> QueryOwnedDisjoining()
        {
            throw new NotImplementedException("Derived property OwnedDisjoining not yet supported");
        }

        /// <summary>
        /// Queries the derived property OwnedElement
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: true, isUnique: true, lowerBound: 0, upperBound: -1, isMany: false, isRequired: false, isContainment: false)]
        public List<Element> QueryOwnedElement()
        {
            throw new NotImplementedException("Derived property OwnedElement not yet supported");
        }

        /// <summary>
        /// Queries the derived property OwnedEndFeature
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: true, isUnique: true, lowerBound: 0, upperBound: -1, isMany: false, isRequired: false, isContainment: false)]
        public List<Feature> QueryOwnedEndFeature()
        {
            throw new NotImplementedException("Derived property OwnedEndFeature not yet supported");
        }

        /// <summary>
        /// Queries the derived property OwnedFeature
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: true, isUnique: true, lowerBound: 0, upperBound: -1, isMany: false, isRequired: false, isContainment: false)]
        public List<Feature> QueryOwnedFeature()
        {
            throw new NotImplementedException("Derived property OwnedFeature not yet supported");
        }

        /// <summary>
        /// Queries the derived property OwnedFeatureChaining
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: true, isUnique: true, lowerBound: 0, upperBound: -1, isMany: false, isRequired: false, isContainment: false)]
        public List<FeatureChaining> QueryOwnedFeatureChaining()
        {
            throw new NotImplementedException("Derived property OwnedFeatureChaining not yet supported");
        }

        /// <summary>
        /// Queries the derived property OwnedFeatureInverting
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: false, isUnique: true, lowerBound: 0, upperBound: -1, isMany: false, isRequired: false, isContainment: false)]
        public List<FeatureInverting> QueryOwnedFeatureInverting()
        {
            throw new NotImplementedException("Derived property OwnedFeatureInverting not yet supported");
        }

        /// <summary>
        /// Queries the derived property OwnedFeatureMembership
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: true, isUnique: true, lowerBound: 0, upperBound: -1, isMany: false, isRequired: false, isContainment: false)]
        public List<FeatureMembership> QueryOwnedFeatureMembership()
        {
            throw new NotImplementedException("Derived property OwnedFeatureMembership not yet supported");
        }

        /// <summary>
        /// Queries the derived property OwnedImport
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: true, isUnique: true, lowerBound: 0, upperBound: -1, isMany: false, isRequired: false, isContainment: false)]
        public List<Import> QueryOwnedImport()
        {
            throw new NotImplementedException("Derived property OwnedImport not yet supported");
        }

        /// <summary>
        /// Queries the derived property OwnedIntersecting
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: true, isUnique: true, lowerBound: 0, upperBound: -1, isMany: false, isRequired: false, isContainment: false)]
        public List<Intersecting> QueryOwnedIntersecting()
        {
            throw new NotImplementedException("Derived property OwnedIntersecting not yet supported");
        }

        /// <summary>
        /// Queries the derived property OwnedMember
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: true, isUnique: true, lowerBound: 0, upperBound: -1, isMany: false, isRequired: false, isContainment: false)]
        public List<Element> QueryOwnedMember()
        {
            throw new NotImplementedException("Derived property OwnedMember not yet supported");
        }

        /// <summary>
        /// Queries the derived property OwnedMembership
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: true, isUnique: true, lowerBound: 0, upperBound: -1, isMany: false, isRequired: false, isContainment: false)]
        public List<Membership> QueryOwnedMembership()
        {
            throw new NotImplementedException("Derived property OwnedMembership not yet supported");
        }

        /// <summary>
        /// Queries the derived property OwnedRedefinition
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: false, isUnique: true, lowerBound: 0, upperBound: -1, isMany: false, isRequired: false, isContainment: false)]
        public List<Redefinition> QueryOwnedRedefinition()
        {
            throw new NotImplementedException("Derived property OwnedRedefinition not yet supported");
        }

        /// <summary>
        /// Queries the derived property OwnedReferenceSubsetting
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: false, isUnique: true, lowerBound: 0, upperBound: 1, isMany: false, isRequired: false, isContainment: false)]
        public ReferenceSubsetting QueryOwnedReferenceSubsetting()
        {
            throw new NotImplementedException("Derived property OwnedReferenceSubsetting not yet supported");
        }

        /// <summary>
        /// The relatedElements of this Relationship that are owned by the Relationship.
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: false, isTransient: false, isUnsettable: false, isDerived: false, isOrdered: true, isUnique: true, lowerBound: 0, upperBound: -1, isMany: false, isRequired: false, isContainment: true)]
        public List<Element> OwnedRelatedElement { get; set; }

        /// <summary>
        /// The Relationships for which this Element is the owningRelatedElement.
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: false, isTransient: false, isUnsettable: false, isDerived: false, isOrdered: true, isUnique: true, lowerBound: 0, upperBound: -1, isMany: false, isRequired: false, isContainment: true)]
        public List<Relationship> OwnedRelationship { get; set; }

        /// <summary>
        /// Queries the derived property OwnedSpecialization
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: true, isUnique: true, lowerBound: 0, upperBound: -1, isMany: false, isRequired: false, isContainment: false)]
        public List<Specialization> QueryOwnedSpecialization()
        {
            throw new NotImplementedException("Derived property OwnedSpecialization not yet supported");
        }

        /// <summary>
        /// Queries the derived property OwnedSubsetting
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: false, isUnique: true, lowerBound: 0, upperBound: -1, isMany: false, isRequired: false, isContainment: false)]
        public List<Subsetting> QueryOwnedSubsetting()
        {
            throw new NotImplementedException("Derived property OwnedSubsetting not yet supported");
        }

        /// <summary>
        /// Queries the derived property OwnedTypeFeaturing
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: true, isUnique: true, lowerBound: 0, upperBound: -1, isMany: false, isRequired: false, isContainment: false)]
        public List<TypeFeaturing> QueryOwnedTypeFeaturing()
        {
            throw new NotImplementedException("Derived property OwnedTypeFeaturing not yet supported");
        }

        /// <summary>
        /// Queries the derived property OwnedTyping
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: true, isUnique: true, lowerBound: 0, upperBound: -1, isMany: false, isRequired: false, isContainment: false)]
        public List<FeatureTyping> QueryOwnedTyping()
        {
            throw new NotImplementedException("Derived property OwnedTyping not yet supported");
        }

        /// <summary>
        /// Queries the derived property OwnedUnioning
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: true, isUnique: true, lowerBound: 0, upperBound: -1, isMany: false, isRequired: false, isContainment: false)]
        public List<Unioning> QueryOwnedUnioning()
        {
            throw new NotImplementedException("Derived property OwnedUnioning not yet supported");
        }

        /// <summary>
        /// Queries the derived property Owner
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: false, isUnique: true, lowerBound: 0, upperBound: 1, isMany: false, isRequired: false, isContainment: false)]
        public Element QueryOwner()
        {
            throw new NotImplementedException("Derived property Owner not yet supported");
        }

        /// <summary>
        /// Queries the derived property OwningFeatureMembership
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: false, isUnique: true, lowerBound: 0, upperBound: 1, isMany: false, isRequired: false, isContainment: false)]
        public FeatureMembership QueryOwningFeatureMembership()
        {
            throw new NotImplementedException("Derived property OwningFeatureMembership not yet supported");
        }

        /// <summary>
        /// Queries the derived property OwningMembership
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: false, isUnique: true, lowerBound: 0, upperBound: 1, isMany: false, isRequired: false, isContainment: false)]
        public OwningMembership QueryOwningMembership()
        {
            throw new NotImplementedException("Derived property OwningMembership not yet supported");
        }

        /// <summary>
        /// Queries the derived property OwningNamespace
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: false, isUnique: true, lowerBound: 0, upperBound: 1, isMany: false, isRequired: false, isContainment: false)]
        public Namespace QueryOwningNamespace()
        {
            throw new NotImplementedException("Derived property OwningNamespace not yet supported");
        }

        /// <summary>
        /// The relatedElement of this Relationship that owns the Relationship, if any.
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: false, isTransient: false, isUnsettable: false, isDerived: false, isOrdered: false, isUnique: true, lowerBound: 0, upperBound: 1, isMany: false, isRequired: false, isContainment: false)]
        public Element OwningRelatedElement { get; set; }

        /// <summary>
        /// The Relationship for which this Element is an ownedRelatedElement, if any.
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: false, isTransient: false, isUnsettable: false, isDerived: false, isOrdered: false, isUnique: true, lowerBound: 0, upperBound: 1, isMany: false, isRequired: false, isContainment: false)]
        public Relationship OwningRelationship { get; set; }

        /// <summary>
        /// Queries the derived property OwningType
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: false, isUnique: true, lowerBound: 0, upperBound: 1, isMany: false, isRequired: false, isContainment: false)]
        public Type QueryOwningType()
        {
            throw new NotImplementedException("Derived property OwningType not yet supported");
        }

        /// <summary>
        /// Queries the derived property Parameter
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: true, isUnique: true, lowerBound: 0, upperBound: -1, isMany: false, isRequired: false, isContainment: false)]
        public List<Feature> QueryParameter()
        {
            throw new NotImplementedException("Derived property Parameter not yet supported");
        }

        /// <summary>
        /// Queries the derived property QualifiedName
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: false, isUnique: true, lowerBound: 0, upperBound: 1, isMany: false, isRequired: false, isContainment: false)]
        public string QueryQualifiedName()
        {
            throw new NotImplementedException("Derived property QualifiedName not yet supported");
        }

        /// <summary>
        /// Queries the derived property RelatedElement
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: true, isUnique: false, lowerBound: 2, upperBound: -1, isMany: false, isRequired: false, isContainment: false)]
        public List<Element> QueryRelatedElement()
        {
            throw new NotImplementedException("Derived property RelatedElement not yet supported");
        }

        /// <summary>
        /// Queries the derived property RelatedFeature
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: true, isUnique: false, lowerBound: 2, upperBound: -1, isMany: false, isRequired: false, isContainment: false)]
        public List<Feature> QueryRelatedFeature()
        {
            throw new NotImplementedException("Derived property RelatedFeature not yet supported");
        }

        /// <summary>
        /// An optional alternative name for the Element that is intended to be shorter or in some way more
        /// succinct than its primary name. It may act as a modeler-specified identifier for the Element, though
        /// it is then the responsibility of the modeler to maintain the uniqueness of this identifier within a
        /// model or relative to some other context.
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: false, isTransient: false, isUnsettable: false, isDerived: false, isOrdered: false, isUnique: true, lowerBound: 0, upperBound: 1, isMany: false, isRequired: false, isContainment: false)]
        public string ShortName { get; set; }

        /// <summary>
        /// The relatedElements from which this Relationship is considered to be directed.
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: false, isTransient: false, isUnsettable: false, isDerived: false, isOrdered: true, isUnique: true, lowerBound: 0, upperBound: -1, isMany: false, isRequired: false, isContainment: false)]
        public List<Element> Source { get; set; }

        /// <summary>
        /// Queries the derived property SourceFeature
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: true, isUnique: true, lowerBound: 0, upperBound: 1, isMany: false, isRequired: false, isContainment: false)]
        public Feature QuerySourceFeature()
        {
            throw new NotImplementedException("Derived property SourceFeature not yet supported");
        }

        /// <summary>
        /// Queries the derived property SourceOutputFeature
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: true, isUnique: false, lowerBound: 0, upperBound: 1, isMany: false, isRequired: false, isContainment: false)]
        public Feature QuerySourceOutputFeature()
        {
            throw new NotImplementedException("Derived property SourceOutputFeature not yet supported");
        }

        /// <summary>
        /// The relatedElements to which this Relationship is considered to be directed.
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: false, isTransient: false, isUnsettable: false, isDerived: false, isOrdered: true, isUnique: true, lowerBound: 0, upperBound: -1, isMany: false, isRequired: false, isContainment: false)]
        public List<Element> Target { get; set; }

        /// <summary>
        /// Queries the derived property TargetFeature
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: true, isUnique: true, lowerBound: 1, upperBound: -1, isMany: false, isRequired: false, isContainment: false)]
        public List<Feature> QueryTargetFeature()
        {
            throw new NotImplementedException("Derived property TargetFeature not yet supported");
        }

        /// <summary>
        /// Queries the derived property TargetInputFeature
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: true, isUnique: false, lowerBound: 0, upperBound: 1, isMany: false, isRequired: false, isContainment: false)]
        public Feature QueryTargetInputFeature()
        {
            throw new NotImplementedException("Derived property TargetInputFeature not yet supported");
        }

        /// <summary>
        /// Queries the derived property TextualRepresentation
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: true, isUnique: true, lowerBound: 0, upperBound: -1, isMany: false, isRequired: false, isContainment: false)]
        public List<TextualRepresentation> QueryTextualRepresentation()
        {
            throw new NotImplementedException("Derived property TextualRepresentation not yet supported");
        }

        /// <summary>
        /// Queries the derived property TransitionStep
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: false, isUnique: true, lowerBound: 0, upperBound: 1, isMany: false, isRequired: false, isContainment: false)]
        public Step QueryTransitionStep()
        {
            throw new NotImplementedException("Derived property TransitionStep not yet supported");
        }

        /// <summary>
        /// Queries the derived property TriggerStep
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: false, isUnique: true, lowerBound: 0, upperBound: -1, isMany: false, isRequired: false, isContainment: false)]
        public List<Step> QueryTriggerStep()
        {
            throw new NotImplementedException("Derived property TriggerStep not yet supported");
        }

        /// <summary>
        /// Queries the derived property Type
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: true, isUnique: true, lowerBound: 1, upperBound: -1, isMany: false, isRequired: false, isContainment: false)]
        public List<Type> QueryType()
        {
            throw new NotImplementedException("Derived property Type not yet supported");
        }

        /// <summary>
        /// Queries the derived property UnioningType
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: true, isUnique: true, lowerBound: 0, upperBound: -1, isMany: false, isRequired: false, isContainment: false)]
        public List<Type> QueryUnioningType()
        {
            throw new NotImplementedException("Derived property UnioningType not yet supported");
        }

    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
