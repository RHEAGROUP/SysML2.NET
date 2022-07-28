// -------------------------------------------------------------------------------------------------
// <copyright file="IPackage.cs" company="RHEA System S.A.">
//
// Copyright 2022 RHEA System S.A.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// </copyright>
// ------------------------------------------------------------------------------------------------

namespace SysML2.NET.DTO
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// A Package is a Namespace used to group Elements, without any instance-level semantics. It may have
    /// one or more model-level evaluable filterCondition Expressions used to filter its
    /// importedMemberships. Any imported member must meet all of the
    /// filterConditions.ownedMembership->forAll(visibility <>
    /// VisibilityKind::protected)ownedImport->forAll(visibility <> VisibilityKind::protected)
    /// </summary>
    public interface IPackage : INamespace
    {
    }
}
