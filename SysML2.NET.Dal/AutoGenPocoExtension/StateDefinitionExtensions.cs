﻿// -------------------------------------------------------------------------------------------------
// <copyright file="StateDefinitionExtensions.cs" company="RHEA System S.A.">
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
    /// A static class that provides extension methods for the <see cref="StateDefinition"/> class
    /// </summary>
    public static class StateDefinitionExtensions
    {
        /// <summary>
        /// Creates a <see cref="Core.DTO.StateDefinition"/> based on the provided POCO
        /// </summary>
        /// <param name="poco">
        /// The subject <see cref="Core.POCO.StateDefinition"/> from which a DTO is to be created
        /// </param>
        /// <returns>
        /// An instance of <see cref="Core.POCO.StateDefinition"/>
        /// </returns>
        public static Core.DTO.StateDefinition ToDto(this Core.POCO.StateDefinition poco)
        {
            var dto = new Core.DTO.StateDefinition();

            dto.Id = poco.Id;
            dto.AliasIds = poco.AliasIds;
            dto.ElementId = poco.ElementId;
            dto.IsAbstract = poco.IsAbstract;
            dto.IsImpliedIncluded = poco.IsImpliedIncluded;
            dto.IsIndividual = poco.IsIndividual;
            dto.IsParallel = poco.IsParallel;
            dto.IsSufficient = poco.IsSufficient;
            dto.IsVariation = poco.IsVariation;
            dto.Name = poco.Name;
            dto.OwnedRelationship = poco.OwnedRelationship.Select(x => x.Id).ToList();
            dto.OwningRelationship = poco.OwningRelationship?.Id;
            dto.ShortName = poco.ShortName;

            return dto;
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
