// -------------------------------------------------------------------------------------------------
// <copyright file="IViewUsage.cs" company="RHEA System S.A.">
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
    /// A ViewUsage is a usage of a ViewDefinition to specify the generation of a view of the members of a
    /// collection of exposedNamespaces. The ViewDefinition can satisfy more viewpoints than its definition,
    /// and it can specialize the rendering specified by its definition.A ViewUsage must subset, directly or
    /// indirectly, the base ViewUsage views from the Systems model library.exposedElement =
    /// ownedImport->selectByKind(Expose).    importedMemberships(Set{}).memberElement->    select(elm |
    /// includeAsExposed(elm))->    asOrderedSet()
    /// </summary>
    public partial interface IViewUsage : IPartUsage
    {
        /// <summary>
        /// Queries the derived property ExposedElement
        /// </summary>
        List<Element> QueryExposedElement();

        /// <summary>
        /// Queries the derived property SatisfiedViewpoint
        /// </summary>
        List<ViewpointUsage> QuerySatisfiedViewpoint();

        /// <summary>
        /// Queries the derived property ViewCondition
        /// </summary>
        List<Expression> QueryViewCondition();

        /// <summary>
        /// Queries the derived property ViewDefinition
        /// </summary>
        ViewDefinition QueryViewDefinition();

        /// <summary>
        /// Queries the derived property ViewRendering
        /// </summary>
        RenderingUsage QueryViewRendering();

    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
