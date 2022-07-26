// -------------------------------------------------------------------------------------------------
// <copyright file="ILoopActionUsage.cs" company="RHEA System S.A.">
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
    /// A LoopActionUsage is an ActionUsage that is typed, directly or indirectly, by the ActionDefinition
    /// LoopAction from the Systems model library. It specifies that its bodyAction should be performed
    /// repeatedly. Its subclasses WhileLoopActionUsage and ForLoopActionUsage provide different ways to
    /// determine how many times the bodyAction should be performed.
    /// </summary>
    public partial interface ILoopActionUsage : IActionUsage
    {
        /// <summary>
        /// Queries the derived property BodyAction
        /// </summary>
        ActionUsage QueryBodyAction();

    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
