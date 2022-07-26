// -------------------------------------------------------------------------------------------------
// <copyright file="IIncludeUseCaseUsage.cs" company="RHEA System S.A.">
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
    /// An IncludeUseCaseUsage is a UseCaseUsage that represents the inclusion of a UseCaseUsage by a
    /// UseCaseDefinition or UseCaseUsage. Unless it is the IncludeUseCaseUsage itself, the UseCaseUsage to
    /// be included is related to the includedUseCase by a ReferenceSubsetting Relationship. An
    /// IncludeUseCaseUsage is also a PerformActionUsage, with its includedUseCase as the performedAction.If
    /// the IncludeUseCaseUsage is owned by a UseCaseDefinition or UseCaseUsage, then it also subsets the
    /// UseCaseUsage UseCase::includedUseCases from the Systems model library.
    /// </summary>
    public partial interface IIncludeUseCaseUsage : IUseCaseUsage, IPerformActionUsage
    {
        /// <summary>
        /// Queries the derived property UseCaseIncluded
        /// </summary>
        UseCaseUsage QueryUseCaseIncluded();

    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
