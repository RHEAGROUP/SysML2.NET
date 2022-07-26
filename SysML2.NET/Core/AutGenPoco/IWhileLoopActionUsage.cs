// -------------------------------------------------------------------------------------------------
// <copyright file="IWhileLoopActionUsage.cs" company="RHEA System S.A.">
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
    /// A WhileLoopActionUsage is a LoopActionUsage that is typed, directly or indirectly, by the
    /// ActionDefinition WhileLoopAction from the Systems model library. It specifies that the bodyClause
    /// ActionUsage should be performed repeatedly while the result of the whileArgument Expression is true
    /// or until the result of the untilArgument Expression (if provided) is true. The whileArgument
    /// Expression is evaluated before each (possible) performance of the bodyClause, and the untilArgument
    /// Expression is evaluated after each performance of the bodyClause.
    /// </summary>
    public partial interface IWhileLoopActionUsage : ILoopActionUsage
    {
        /// <summary>
        /// Queries the derived property UntilArgument
        /// </summary>
        Expression QueryUntilArgument();

        /// <summary>
        /// Queries the derived property WhileArgument
        /// </summary>
        Expression QueryWhileArgument();

    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
