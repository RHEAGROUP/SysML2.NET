﻿// -------------------------------------------------------------------------------------------------
// <copyright file="DependencyExtensions.cs" company="RHEA System S.A.">
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
    /// A static class that provides extension methods for the <see cref="Dependency"/> class
    /// </summary>
    public static class DependencyExtensions
    {
        /// <summary>
        /// Updates the value properties of the <see cref="Dependency"/> by setting the value equal to that of the dto
        /// Removes deleted objects from the reference properties and returns the unique identifiers
        /// of the objects that have been removed from contained properties
        /// </summary>
        /// <param name="poco">
        /// The <see cref="Dependency"/> that is to be updated
        /// </param>
        /// <param name="dto">
        /// The DTO that is used to update the <see cref="Dependency"/> with
        /// </param>
        /// <returns>
        /// The unique identifiers of the objects that have been removed from contained properties
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when the <paramref name="poco"/> or <paramref name="dto"/> is null
        /// </exception>
        public static IEnumerable<Guid> UpdateValueAndRemoveDeletedReferenceProperties(this Core.POCO.Dependency poco, Core.DTO.Dependency dto)
        {
            if (poco == null)
            {
                throw new ArgumentNullException(nameof(poco), $"the {nameof(poco)} may not be null");
            }

            if (dto == null)
            {
                throw new ArgumentNullException(nameof(dto), $"the {nameof(dto)} may not be null");
            }

            var identifiersOfObjectsToDelete = new List<Guid>();

            poco.AliasIds = dto.AliasIds;

            var clientToDelete = poco.Client.Select(x => x.Id).Except(dto.Client);
            foreach (var identifier in clientToDelete)
            {
                poco.Client.Remove(poco.Client.Single(x => x.Id == identifier));
            }

            poco.ElementId = dto.ElementId;

            poco.IsImplied = dto.IsImplied;

            poco.IsImpliedIncluded = dto.IsImpliedIncluded;

            poco.Name = dto.Name;

            var ownedRelatedElementToDelete = poco.OwnedRelatedElement.Select(x => x.Id).Except(dto.OwnedRelatedElement);
            foreach (var identifier in ownedRelatedElementToDelete)
            {
                poco.OwnedRelatedElement.Remove(poco.OwnedRelatedElement.Single(x => x.Id == identifier));
            }
            identifiersOfObjectsToDelete.AddRange(ownedRelatedElementToDelete);

            var ownedRelationshipToDelete = poco.OwnedRelationship.Select(x => x.Id).Except(dto.OwnedRelationship);
            foreach (var identifier in ownedRelationshipToDelete)
            {
                poco.OwnedRelationship.Remove(poco.OwnedRelationship.Single(x => x.Id == identifier));
            }
            identifiersOfObjectsToDelete.AddRange(ownedRelationshipToDelete);

            poco.ShortName = dto.ShortName;

            var sourceToDelete = poco.Source.Select(x => x.Id).Except(dto.Source);
            foreach (var identifier in sourceToDelete)
            {
                poco.Source.Remove(poco.Source.Single(x => x.Id == identifier));
            }

            var supplierToDelete = poco.Supplier.Select(x => x.Id).Except(dto.Supplier);
            foreach (var identifier in supplierToDelete)
            {
                poco.Supplier.Remove(poco.Supplier.Single(x => x.Id == identifier));
            }

            var targetToDelete = poco.Target.Select(x => x.Id).Except(dto.Target);
            foreach (var identifier in targetToDelete)
            {
                poco.Target.Remove(poco.Target.Single(x => x.Id == identifier));
            }


            return identifiersOfObjectsToDelete;
        }

        /// <summary>
        /// Updates the Reference properties of the <see cref="Dependency"/> using the data (identifiers) encapsulated in the DTO
        /// and the provided cache to find the referenced object.
        /// </summary>
        /// <param name="poco">
        /// The <see cref="Dependency"/> that is to be updated
        /// </param>
        /// <param name="dto">
        /// The DTO that is used to update the <see cref="Dependency"/> with
        /// </param>
        /// <param name="cache">
        /// The <see cref="ConcurrentDictionary{Guid, Lazy{Core.POCO.IElement}}"/> that contains the
        /// <see cref="Core.POCO.IElement"/>s that are know and cached.
        /// </param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void UpdateReferenceProperties(this Core.POCO.Dependency poco, Core.DTO.Dependency dto, ConcurrentDictionary<Guid, Lazy<Core.POCO.IElement>> cache)
        {
            if (poco == null)
            {
                throw new ArgumentNullException(nameof(poco), $"the {nameof(poco)} may not be null");
            }

            if (dto == null)
            {
                throw new ArgumentNullException(nameof(dto), $"the {nameof(dto)} may not be null");
            }

            if (cache == null)
            {
                throw new ArgumentNullException(nameof(cache), $"the {nameof(cache)} may not be null");
            }

            Lazy<Core.POCO.IElement> lazyPoco;

            var clientToAdd = dto.Client.Except(poco.Client.Select(x => x.Id));
            foreach (var identifier in clientToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    poco.Client.Add((Core.POCO.Element)lazyPoco.Value);
                }
            }

            var ownedRelatedElementToAdd = dto.OwnedRelatedElement.Except(poco.OwnedRelatedElement.Select(x => x.Id));
            foreach (var identifier in ownedRelatedElementToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    poco.OwnedRelatedElement.Add((Core.POCO.Element)lazyPoco.Value);
                }
            }

            var ownedRelationshipToAdd = dto.OwnedRelationship.Except(poco.OwnedRelationship.Select(x => x.Id));
            foreach (var identifier in ownedRelationshipToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    poco.OwnedRelationship.Add((Core.POCO.Relationship)lazyPoco.Value);
                }
            }

            if (dto.OwningRelatedElement.HasValue && cache.TryGetValue(dto.OwningRelatedElement.Value, out lazyPoco))
            {
                poco.OwningRelatedElement = (Core.POCO.Element)lazyPoco.Value;
            }
            else
            {
                poco.OwningRelatedElement = null;
            }

            if (dto.OwningRelationship.HasValue && cache.TryGetValue(dto.OwningRelationship.Value, out lazyPoco))
            {
                poco.OwningRelationship = (Core.POCO.Relationship)lazyPoco.Value;
            }
            else
            {
                poco.OwningRelationship = null;
            }

            var sourceToAdd = dto.Source.Except(poco.Source.Select(x => x.Id));
            foreach (var identifier in sourceToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    poco.Source.Add((Core.POCO.Element)lazyPoco.Value);
                }
            }

            var supplierToAdd = dto.Supplier.Except(poco.Supplier.Select(x => x.Id));
            foreach (var identifier in supplierToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    poco.Supplier.Add((Core.POCO.Element)lazyPoco.Value);
                }
            }

            var targetToAdd = dto.Target.Except(poco.Target.Select(x => x.Id));
            foreach (var identifier in targetToAdd)
            {
                if (cache.TryGetValue(identifier, out lazyPoco))
                {
                    poco.Target.Add((Core.POCO.Element)lazyPoco.Value);
                }
            }

        }

        /// <summary>
        /// Creates a <see cref="Core.DTO.Dependency"/> based on the provided POCO
        /// </summary>
        /// <param name="poco">
        /// The subject <see cref="Core.POCO.Dependency"/> from which a DTO is to be created
        /// </param>
        /// <returns>
        /// An instance of <see cref="Core.POCO.Dependency"/>
        /// </returns>
        public static Core.DTO.Dependency ToDto(this Core.POCO.Dependency poco)
        {
            var dto = new Core.DTO.Dependency();

            dto.Id = poco.Id;
            dto.AliasIds = poco.AliasIds;
            dto.Client = poco.Client.Select(x => x.Id).ToList();
            dto.ElementId = poco.ElementId;
            dto.IsImplied = poco.IsImplied;
            dto.IsImpliedIncluded = poco.IsImpliedIncluded;
            dto.Name = poco.Name;
            dto.OwnedRelatedElement = poco.OwnedRelatedElement.Select(x => x.Id).ToList();
            dto.OwnedRelationship = poco.OwnedRelationship.Select(x => x.Id).ToList();
            dto.OwningRelatedElement = poco.OwningRelatedElement?.Id;
            dto.OwningRelationship = poco.OwningRelationship?.Id;
            dto.ShortName = poco.ShortName;
            dto.Source = poco.Source.Select(x => x.Id).ToList();
            dto.Supplier = poco.Supplier.Select(x => x.Id).ToList();
            dto.Target = poco.Target.Select(x => x.Id).ToList();

            return dto;
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------
