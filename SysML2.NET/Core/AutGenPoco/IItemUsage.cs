// -------------------------------------------------------------------------------------------------
// <copyright file="IItemUsage.cs" company="RHEA System S.A.">
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
    /// An ItemUsage is a Usage whose type is a Structure. Nominally, if the type is an ItemDefinition, an
    /// ItemUsage is a Usage of that ItemDefinition within a system. However, other types of Kernel
    /// Structure are also allowed, to permit use of Structures from the Kernel Library.An ItemUsage must
    /// subset, directly or indirectly, the base ItemUsage items from the Systems model library.
    /// </summary>
    public partial interface IItemUsage : IOccurrenceUsage
    {
        /// <summary>
        /// Queries the derived property ItemDefinition
        /// </summary>
        List<Structure> QueryItemDefinition();

    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
