// -------------------------------------------------------------------------------------------------
// <copyright file="IDisjoining.cs" company="RHEA System S.A.">
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
    /// A Disjoining is a Relationship between Types asserted to have interpretations that are not shared
    /// (disjoint) between them, identified as typeDisjoined and disjoiningType. For example, a Classifier
    /// for mammals is disjoint from a Classifier for minerals, and a Feature for people&#39;s parents is
    /// disjoint from a Feature for their children.
    /// </summary>
    public partial interface IDisjoining : IRelationship
    {
        /// <summary>
        /// </summary>
        Type DisjoiningType { get; set; }

        /// <summary>
        /// Queries the derived property OwningType
        /// </summary>
        Type QueryOwningType();

        /// <summary>
        /// </summary>
        Type TypeDisjoined { get; set; }

    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
