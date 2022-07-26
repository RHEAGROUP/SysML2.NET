// -------------------------------------------------------------------------------------------------
// <copyright file="IPortUsage.cs" company="RHEA System S.A.">
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
    /// A PortUsage is a usage of a PortDefinition. A PortUsage must be owned by a PartDefinition, a
    /// PortDefinition, a PartUsage or another PortUsage.  Any nestedUsages of a PortUsage, other than
    /// nested PortUsages, must not be composite.A PortUsage must subset, directly or indirectly, the
    /// PortUsage ports from the Systems model library.nestedUsage->    select(not oclIsKindOf(PortUsage))->
    /// forAll(not isComposite)
    /// </summary>
    public partial interface IPortUsage : IOccurrenceUsage
    {
        /// <summary>
        /// Queries the derived property PortDefinition
        /// </summary>
        List<PortDefinition> QueryPortDefinition();

    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
