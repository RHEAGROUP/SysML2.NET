// -------------------------------------------------------------------------------------------------
// <copyright file="IFeatureTyping.cs" company="RHEA System S.A.">
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
    /// FeatureTyping is Specialization in which the specific Type is a Feature. This means the set of
    /// instances of the (specific) typedFeature is a subset of the set of instances of the (general) type.
    /// In the simplest case, the type is a Classifier, whereupon the typedFeature subset has instances
    /// interpreted as sequences ending in things (in the modeled universe) that are instances of the
    /// Classifier.
    /// </summary>
    public partial interface IFeatureTyping : ISpecialization
    {
        /// <summary>
        /// Queries the derived property OwningFeature
        /// </summary>
        Feature QueryOwningFeature();

        /// <summary>
        /// </summary>
        Type Type { get; set; }

        /// <summary>
        /// </summary>
        Feature TypedFeature { get; set; }

    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
