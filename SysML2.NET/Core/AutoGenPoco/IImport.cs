﻿// -------------------------------------------------------------------------------------------------
// <copyright file="IImport.cs" company="RHEA System S.A.">
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
    /// An Import is a Relationship between an importOwningNamespace in which one or more of the visible
    /// Memberships of the importedNamespace become importedMemberships of the importOwningNamespace. If
    /// isImportAll = false (the default), then only public Memberships are considered &quot;visible&quot;.
    /// If isImportAll = true, then all Memberships are considered &quot;visible&quot;, regardless of their
    /// declared visibility.If no importedMemberName is given, then all visible Memberships are imported
    /// from the importedNamespace. If isRecursive = true, then visible Memberships are also recursively
    /// imported from all visible ownedMembers of the Namespace that are also Namespaces.If an 
    /// importedMemberName is given, then the Membership whose effectiveMemberName is that name is imported
    /// from the importedNamespace, if it is visible. If isRecursive = true and the imported memberElement
    /// is a Namespace, then visible Memberships are also recursively imported from that Namespace and its
    /// owned sub-Namespaces.
    /// </summary>
    public partial interface IImport : IRelationship
    {
        /// <summary>
        /// The effectiveMemberName of the Membership of the importedNamspace to be imported. If not given, all
        /// public Memberships of the importedNamespace are imported.
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: false, isTransient: false, isUnsettable: false, isDerived: false, isOrdered: false, isUnique: true, lowerBound: 0, upperBound: 1, isMany: false, isRequired: false, isContainment: false)]
        string ImportedMemberName { get; set; }

        /// <summary>
        /// The Namespace whose visible members are imported by this Import.
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: false, isTransient: false, isUnsettable: false, isDerived: false, isOrdered: false, isUnique: true, lowerBound: 1, upperBound: 1, isMany: false, isRequired: false, isContainment: false)]
        Namespace ImportedNamespace { get; set; }

        /// <summary>
        /// Queries the derived property ImportOwningNamespace
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: true, isTransient: true, isUnsettable: false, isDerived: true, isOrdered: false, isUnique: true, lowerBound: 1, upperBound: 1, isMany: false, isRequired: false, isContainment: false)]
        Namespace QueryImportOwningNamespace();

        /// <summary>
        /// Whether to import memberships without regard to declared visibility.
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: false, isTransient: false, isUnsettable: false, isDerived: false, isOrdered: false, isUnique: true, lowerBound: 1, upperBound: 1, isMany: false, isRequired: false, isContainment: false)]
        bool IsImportAll { get; set; }

        /// <summary>
        /// Whether to recursively import Memberships from visible, owned sub-namespaces.
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: false, isTransient: false, isUnsettable: false, isDerived: false, isOrdered: false, isUnique: true, lowerBound: 1, upperBound: 1, isMany: false, isRequired: false, isContainment: false)]
        bool IsRecursive { get; set; }

        /// <summary>
        /// The visibility level of the imported members from this Import relative to the importOwningNamespace.
        /// </summary>
        [EFeature(isChangeable: true, isVolatile: false, isTransient: false, isUnsettable: false, isDerived: false, isOrdered: false, isUnique: true, lowerBound: 1, upperBound: 1, isMany: false, isRequired: false, isContainment: false)]
        VisibilityKind Visibility { get; set; }

    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
