﻿// -------------------------------------------------------------------------------------------------
// <copyright file="ImportExtensions.cs" company="RHEA System S.A.">
//
//   Copyright 2022-2023 RHEA System S.A.
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

namespace SysML2.NET.Dal
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Linq;

    using Core.POCO;

    /// <summary>
    /// A static class that provides extension methods for the <see cref="Import"/> class
    /// </summary>
    public static class ImportExtensions
    {
        /// <summary>
        /// Creates a <see cref="Core.DTO.Import"/> based on the provided POCO
        /// </summary>
        /// <param name="poco">
        /// The subject <see cref="Core.POCO.Import"/> from which a DTO is to be created
        /// </param>
        /// <returns>
        /// An instance of <see cref="Core.POCO.Import"/>
        /// </returns>
        public static Core.DTO.Import ToDto(this Core.POCO.Import poco)
        {
            var dto = new Core.DTO.Import();

            dto.Id = poco.Id;
            dto.AliasIds = poco.AliasIds;
            dto.ElementId = poco.ElementId;
            dto.ImportedMemberName = poco.ImportedMemberName;
            dto.ImportedNamespace = poco.ImportedNamespace.Id;
            dto.IsImplied = poco.IsImplied;
            dto.IsImpliedIncluded = poco.IsImpliedIncluded;
            dto.IsImportAll = poco.IsImportAll;
            dto.IsRecursive = poco.IsRecursive;
            dto.Name = poco.Name;
            dto.OwnedRelatedElement = poco.OwnedRelatedElement.Select(x => x.Id).ToList();
            dto.OwnedRelationship = poco.OwnedRelationship.Select(x => x.Id).ToList();
            dto.OwningRelatedElement = poco.OwningRelatedElement?.Id;
            dto.OwningRelationship = poco.OwningRelationship?.Id;
            dto.ShortName = poco.ShortName;
            dto.Source = poco.Source.Select(x => x.Id).ToList();
            dto.Target = poco.Target.Select(x => x.Id).ToList();
            dto.Visibility = poco.Visibility;

            return dto;
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------