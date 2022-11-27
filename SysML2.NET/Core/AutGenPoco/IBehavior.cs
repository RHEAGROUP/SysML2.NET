// -------------------------------------------------------------------------------------------------
// <copyright file="IBehavior.cs" company="RHEA System S.A.">
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
    /// A Behavior coordinates occurrences of other Behaviors, as well as changes in objects. Behaviors
    /// can be decomposed into Steps and be characterized by
    /// parameters.allSupertypes()->includes(resolve("Performances::Performance"))
    /// </summary>
    public partial interface IBehavior : IClass
    {
        /// <summary>
        /// Queries the derived property Parameter
        /// </summary>
        List<Feature> QueryParameter();

        /// <summary>
        /// Queries the derived property Step
        /// </summary>
        List<Step> QueryStep();

    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------