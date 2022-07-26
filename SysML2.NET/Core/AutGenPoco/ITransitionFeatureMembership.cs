// -------------------------------------------------------------------------------------------------
// <copyright file="ITransitionFeatureMembership.cs" company="RHEA System S.A.">
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
    /// A TransitionFeatureMembership is a FeatureMembership for a trigger, guard or effect of a
    /// TransitionUsage. The ownedMemberFeature must be a Step. For a trigger, the ownedMemberFeature must
    /// more specifically be a Transfer, while for a guard it must be an Expression with a result type of
    /// Boolean.
    /// </summary>
    public partial interface ITransitionFeatureMembership : IFeatureMembership
    {
        /// <summary>
        /// Whether this TransitionFeatureMembership is for a trigger, guard or effect.
        /// </summary>
        TransitionFeatureKind Kind { get; set; }

        /// <summary>
        /// Queries the derived property TransitionFeature
        /// </summary>
        Step QueryTransitionFeature();

    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
