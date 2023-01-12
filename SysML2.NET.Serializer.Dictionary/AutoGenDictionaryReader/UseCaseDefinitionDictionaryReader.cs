// -------------------------------------------------------------------------------------------------
// <copyright file="UseCaseDefinitionDictionaryReader.cs" company="RHEA System S.A.">
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

namespace SysML2.NET.Serializer.Dictionary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using SysML2.NET.Common;
    using SysML2.NET.Core;
    using SysML2.NET.Core.DTO;

    /// <summary>
    /// The purpose of the <see cref="UseCaseDefinitionDictionaryReader"/> is to read (convert)
    /// a <see cref="Dictionary{String, Object}"/> from an <see cref="IUseCaseDefinition"/>
    /// </summary>
    public static class UseCaseDefinitionDictionaryReader
    {
        /// <summary>
        /// Reads a <see cref="IUseCaseDefinition"/> from a <see cref="Dictionary{String, Object}"/> that contains a key-value-pair
        /// for each property.
        /// </summary>
        /// <param name="dictionary">
        /// The subject <see cref="Dictionary{String, Object}"/> that is to be converted into a <see cref="IUseCaseDefinition"/>
        /// </param>
        /// <param name="dictionaryKind">
        /// The source <see cref="DictionaryKind"/> that is to be read from
        /// </param>
        /// <returns>
        /// An instance of <see cref="IUseCaseDefinition"/>
        /// </returns>
        /// <remarks>
        /// When the <see cref="DictionaryKind"/> is <see cref="DictionaryKind.Complex"/> then the values that are read from the
        /// <see cref="Dictionary{String, Object}"/> are read as is. When the <see cref="DictionaryKind"/> is <see cref="DictionaryKind.Simplified"/>
        /// then the following applies:
        /// The values that are of the following types are read as is:
        ///   - Number, an abstract type, which has the subtypes Integer and Float
        ///   - String
        ///   - Boolean
        ///   - The spatial type Point
        ///   - Temporal types: Date, Time, LocalTime, DateTime, LocalDateTime and Duration
        /// values of other types are converted from string, in case these are an <see cref="IEnumerable{T}"/> then
        /// the values are converted from an Array of String using JSON notation, i.e. [ value_1, ..., value_n ]
        /// </remarks>
        public static IData Read(Dictionary<string, object> dictionary, DictionaryKind dictionaryKind)
        {
            switch (dictionaryKind)
            {
                case DictionaryKind.Complex:
                    return ReadComplex(dictionary);
                case DictionaryKind.Simplified:
                    return ReadSimplified(dictionary);
                default:
                    throw new NotSupportedException($"The dictionaryKind:{dictionaryKind} is not supported");
            }
        }

        /// <summary>
        /// Reads a <see cref="IUseCaseDefinition"/> from a <see cref="Dictionary{String, Object}"/> that contains a key-value-pair
        /// for each property.
        /// </summary>
        /// <param name="dictionary">
        /// The subject <see cref="Dictionary{String, Object}"/> that is to be converted into a <see cref="IUseCaseDefinition"/>
        /// </param>
        /// <returns>
        /// An instance of <see cref="IUseCaseDefinition"/>
        /// </returns>
        /// <remarks>
        /// When the <see cref="DictionaryKind"/> is <see cref="DictionaryKind.Complex"/> then the values that are read from the
        /// <see cref="Dictionary{String, Object}"/> are read as is. When the <see cref="DictionaryKind"/> is <see cref="DictionaryKind.Simplified"/>
        /// then the following applies:
        /// The values that are of the following types are read as is:
        ///   - Number, an abstract type, which has the subtypes Integer and Float
        ///   - String
        ///   - Boolean
        ///   - The spatial type Point
        ///   - Temporal types: Date, Time, LocalTime, DateTime, LocalDateTime and Duration
        /// values of other types are converted from string, in case these are an <see cref="IEnumerable{T}"/> then
        /// the values are converted from an Array of String using JSON notation, i.e. [ value_1, ..., value_n ]
        /// </remarks>
        private static IUseCaseDefinition ReadSimplified(Dictionary<string, object> dictionary)
        {
            var useCaseDefinitionInstance = DictionaryNullAndTypeCheck(dictionary);

            if (!dictionary.TryGetValue("aliasIds", out object aliasIdsObject))
            {
                throw new ArgumentException("The aliasIds property is missing from the dictionary, the dictionary cannot be converted into a UseCaseDefinition");
            }
            List<string> aliasIdsFeature = aliasIdsObject as List<string>;

            if (!dictionary.TryGetValue("elementId", out object elementIdObject))
            {
                throw new ArgumentException("The elementId property is missing from the dictionary, the dictionary cannot be converted into a UseCaseDefinition");
            }
            string elementIdFeature = Convert.ToString(elementIdObject);

            if (!dictionary.TryGetValue("isAbstract", out object isAbstractObject))
            {
                throw new ArgumentException("The isAbstract property is missing from the dictionary, the dictionary cannot be converted into a UseCaseDefinition");
            }
            bool isAbstractFeature = Convert.ToBoolean(isAbstractObject);

            if (!dictionary.TryGetValue("isImpliedIncluded", out object isImpliedIncludedObject))
            {
                throw new ArgumentException("The isImpliedIncluded property is missing from the dictionary, the dictionary cannot be converted into a UseCaseDefinition");
            }
            bool isImpliedIncludedFeature = Convert.ToBoolean(isImpliedIncludedObject);

            if (!dictionary.TryGetValue("isIndividual", out object isIndividualObject))
            {
                throw new ArgumentException("The isIndividual property is missing from the dictionary, the dictionary cannot be converted into a UseCaseDefinition");
            }
            bool isIndividualFeature = Convert.ToBoolean(isIndividualObject);

            if (!dictionary.TryGetValue("isSufficient", out object isSufficientObject))
            {
                throw new ArgumentException("The isSufficient property is missing from the dictionary, the dictionary cannot be converted into a UseCaseDefinition");
            }
            bool isSufficientFeature = Convert.ToBoolean(isSufficientObject);

            if (!dictionary.TryGetValue("isVariation", out object isVariationObject))
            {
                throw new ArgumentException("The isVariation property is missing from the dictionary, the dictionary cannot be converted into a UseCaseDefinition");
            }
            bool isVariationFeature = Convert.ToBoolean(isVariationObject);

            if (!dictionary.TryGetValue("name", out object nameObject))
            {
                throw new ArgumentException("The name property is missing from the dictionary, the dictionary cannot be converted into a UseCaseDefinition");
            }
            string nameFeature = nameObject == null ? null : Convert.ToString(nameObject);

            if (!dictionary.TryGetValue("ownedRelationship", out object ownedRelationshipObject))
            {
                throw new ArgumentException("The ownedRelationship property is missing from the dictionary, the dictionary cannot be converted into a UseCaseDefinition");
            }
            List<Guid> ownedRelationshipFeature = (ownedRelationshipObject as List<string>)?.Select(Guid.Parse).ToList();

            if (!dictionary.TryGetValue("owningRelationship", out object owningRelationshipObject))
            {
                throw new ArgumentException("The owningRelationship property is missing from the dictionary, the dictionary cannot be converted into a UseCaseDefinition");
            }
            Guid? owningRelationshipFeature = owningRelationshipObject == null ? (Guid?)null : Guid.Parse(Convert.ToString(owningRelationshipObject));

            if (!dictionary.TryGetValue("shortName", out object shortNameObject))
            {
                throw new ArgumentException("The shortName property is missing from the dictionary, the dictionary cannot be converted into a UseCaseDefinition");
            }
            string shortNameFeature = shortNameObject == null ? null : Convert.ToString(shortNameObject);


            useCaseDefinitionInstance.AliasIds = aliasIdsFeature ?? new List<string>();
            useCaseDefinitionInstance.ElementId = elementIdFeature;
            useCaseDefinitionInstance.IsAbstract = isAbstractFeature;
            useCaseDefinitionInstance.IsImpliedIncluded = isImpliedIncludedFeature;
            useCaseDefinitionInstance.IsIndividual = isIndividualFeature;
            useCaseDefinitionInstance.IsSufficient = isSufficientFeature;
            useCaseDefinitionInstance.IsVariation = isVariationFeature;
            useCaseDefinitionInstance.Name = nameFeature;
            useCaseDefinitionInstance.OwnedRelationship = ownedRelationshipFeature ?? new List<Guid>();
            useCaseDefinitionInstance.OwningRelationship = owningRelationshipFeature;
            useCaseDefinitionInstance.ShortName = shortNameFeature;

            return useCaseDefinitionInstance;
        }

        /// <summary>
        /// Reads a <see cref="IUseCaseDefinition"/> from a <see cref="Dictionary{String, Object}"/> that contains a key-value-pair
        /// for each property.
        /// </summary>
        /// <param name="dictionary">
        /// The subject <see cref="Dictionary{String, Object}"/> that is to be converted into a <see cref="IUseCaseDefinition"/>
        /// </param>
        /// <returns>
        /// An instance of <see cref="IUseCaseDefinition"/>
        /// </returns>
        private static IUseCaseDefinition ReadComplex(Dictionary<string, object> dictionary)
        {
            var useCaseDefinitionInstance = DictionaryNullAndTypeCheck(dictionary);

            if (!dictionary.TryGetValue("aliasIds", out object aliasIdsObject))
            {
                throw new ArgumentException("The aliasIds property is missing from the dictionary, the dictionary cannot be converted into a UseCaseDefinition");
            }
            List<string> aliasIdsFeature = aliasIdsObject as List<string>;

            if (!dictionary.TryGetValue("elementId", out object elementIdObject))
            {
                throw new ArgumentException("The elementId property is missing from the dictionary, the dictionary cannot be converted into a UseCaseDefinition");
            }
            string elementIdFeature = Convert.ToString(elementIdObject);

            if (!dictionary.TryGetValue("isAbstract", out object isAbstractObject))
            {
                throw new ArgumentException("The isAbstract property is missing from the dictionary, the dictionary cannot be converted into a UseCaseDefinition");
            }
            bool isAbstractFeature = Convert.ToBoolean(isAbstractObject);

            if (!dictionary.TryGetValue("isImpliedIncluded", out object isImpliedIncludedObject))
            {
                throw new ArgumentException("The isImpliedIncluded property is missing from the dictionary, the dictionary cannot be converted into a UseCaseDefinition");
            }
            bool isImpliedIncludedFeature = Convert.ToBoolean(isImpliedIncludedObject);

            if (!dictionary.TryGetValue("isIndividual", out object isIndividualObject))
            {
                throw new ArgumentException("The isIndividual property is missing from the dictionary, the dictionary cannot be converted into a UseCaseDefinition");
            }
            bool isIndividualFeature = Convert.ToBoolean(isIndividualObject);

            if (!dictionary.TryGetValue("isSufficient", out object isSufficientObject))
            {
                throw new ArgumentException("The isSufficient property is missing from the dictionary, the dictionary cannot be converted into a UseCaseDefinition");
            }
            bool isSufficientFeature = Convert.ToBoolean(isSufficientObject);

            if (!dictionary.TryGetValue("isVariation", out object isVariationObject))
            {
                throw new ArgumentException("The isVariation property is missing from the dictionary, the dictionary cannot be converted into a UseCaseDefinition");
            }
            bool isVariationFeature = Convert.ToBoolean(isVariationObject);

            if (!dictionary.TryGetValue("name", out object nameObject))
            {
                throw new ArgumentException("The name property is missing from the dictionary, the dictionary cannot be converted into a UseCaseDefinition");
            }
            string nameFeature = nameObject == null ? null : Convert.ToString(nameObject);

            if (!dictionary.TryGetValue("ownedRelationship", out object ownedRelationshipObject))
            {
                throw new ArgumentException("The ownedRelationship property is missing from the dictionary, the dictionary cannot be converted into a UseCaseDefinition");
            }
            List<Guid> ownedRelationshipFeature = (ownedRelationshipObject as List<Guid>);

            if (!dictionary.TryGetValue("owningRelationship", out object owningRelationshipObject))
            {
                throw new ArgumentException("The owningRelationship property is missing from the dictionary, the dictionary cannot be converted into a UseCaseDefinition");
            }
            Guid? owningRelationshipFeature = (Guid?)owningRelationshipObject;

            if (!dictionary.TryGetValue("shortName", out object shortNameObject))
            {
                throw new ArgumentException("The shortName property is missing from the dictionary, the dictionary cannot be converted into a UseCaseDefinition");
            }
            string shortNameFeature = shortNameObject == null ? null : Convert.ToString(shortNameObject);


            useCaseDefinitionInstance.AliasIds = aliasIdsFeature ?? new List<string>();
            useCaseDefinitionInstance.ElementId = elementIdFeature;
            useCaseDefinitionInstance.IsAbstract = isAbstractFeature;
            useCaseDefinitionInstance.IsImpliedIncluded = isImpliedIncludedFeature;
            useCaseDefinitionInstance.IsIndividual = isIndividualFeature;
            useCaseDefinitionInstance.IsSufficient = isSufficientFeature;
            useCaseDefinitionInstance.IsVariation = isVariationFeature;
            useCaseDefinitionInstance.Name = nameFeature;
            useCaseDefinitionInstance.OwnedRelationship = ownedRelationshipFeature ?? new List<Guid>();
            useCaseDefinitionInstance.OwningRelationship = owningRelationshipFeature;
            useCaseDefinitionInstance.ShortName = shortNameFeature;

            return useCaseDefinitionInstance;
        }

        /// <summary>
        /// Checks whether the <see cref="Dictionary{String, Object}"/> is not null and whether it is
        /// of type <see cref="UseCaseDefinition"/>
        /// </summary>
        /// <param name="dictionary">
        /// The subject <see cref="Dictionary{String, Object}"/> that contains the key-value pairs of
        /// properties and values.
        /// </param>
        /// <returns>
        /// an instance of <see cref="IUseCaseDefinition"/>
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="dictionary"/> is null
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="dictionary"/> is not of type <see cref="UseCaseDefinition"/>
        /// </exception>
        private static IUseCaseDefinition DictionaryNullAndTypeCheck(Dictionary<string, object> dictionary)
        {
            if (dictionary == null)
            {
                throw new ArgumentNullException("dictionary", "The dictionary may not be null");
            }

            if (!dictionary.TryGetValue("@type", out object typeObject))
            {
                throw new ArgumentException("The type property is missing from the dictionary, the dictionary cannot be converted into a UseCaseDefinition");
            }

            var type = Convert.ToString(typeObject);

            if (type != "UseCaseDefinition")
            {
                throw new ArgumentException($"The dictionary contains an Object is of type {type} and can therefore not be converted into a UseCaseDefinition");
            }

            if (!dictionary.TryGetValue("@id", out object idObject))
            {
                throw new ArgumentException("The id property is missing from the dictionary, the dictionary cannot be converted into a UseCaseDefinition");
            }
            var id = Guid.Parse(Convert.ToString(idObject));

            var useCaseDefinitionInstance = new Core.DTO.UseCaseDefinition
            {
                Id = id
            };

            return useCaseDefinitionInstance;
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------