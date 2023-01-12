// -------------------------------------------------------------------------------------------------
// <copyright file="TextualRepresentationDictionaryReader.cs" company="RHEA System S.A.">
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
    /// The purpose of the <see cref="TextualRepresentationDictionaryReader"/> is to read (convert)
    /// a <see cref="Dictionary{String, Object}"/> from an <see cref="ITextualRepresentation"/>
    /// </summary>
    public static class TextualRepresentationDictionaryReader
    {
        /// <summary>
        /// Reads a <see cref="ITextualRepresentation"/> from a <see cref="Dictionary{String, Object}"/> that contains a key-value-pair
        /// for each property.
        /// </summary>
        /// <param name="dictionary">
        /// The subject <see cref="Dictionary{String, Object}"/> that is to be converted into a <see cref="ITextualRepresentation"/>
        /// </param>
        /// <param name="dictionaryKind">
        /// The source <see cref="DictionaryKind"/> that is to be read from
        /// </param>
        /// <returns>
        /// An instance of <see cref="ITextualRepresentation"/>
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
        /// Reads a <see cref="ITextualRepresentation"/> from a <see cref="Dictionary{String, Object}"/> that contains a key-value-pair
        /// for each property.
        /// </summary>
        /// <param name="dictionary">
        /// The subject <see cref="Dictionary{String, Object}"/> that is to be converted into a <see cref="ITextualRepresentation"/>
        /// </param>
        /// <returns>
        /// An instance of <see cref="ITextualRepresentation"/>
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
        private static ITextualRepresentation ReadSimplified(Dictionary<string, object> dictionary)
        {
            var textualRepresentationInstance = DictionaryNullAndTypeCheck(dictionary);

            if (!dictionary.TryGetValue("aliasIds", out object aliasIdsObject))
            {
                throw new ArgumentException("The aliasIds property is missing from the dictionary, the dictionary cannot be converted into a TextualRepresentation");
            }
            List<string> aliasIdsFeature = aliasIdsObject as List<string>;

            if (!dictionary.TryGetValue("annotation", out object annotationObject))
            {
                throw new ArgumentException("The annotation property is missing from the dictionary, the dictionary cannot be converted into a TextualRepresentation");
            }
            List<Guid> annotationFeature = (annotationObject as List<string>)?.Select(Guid.Parse).ToList();

            if (!dictionary.TryGetValue("body", out object bodyObject))
            {
                throw new ArgumentException("The body property is missing from the dictionary, the dictionary cannot be converted into a TextualRepresentation");
            }
            string bodyFeature = Convert.ToString(bodyObject);

            if (!dictionary.TryGetValue("elementId", out object elementIdObject))
            {
                throw new ArgumentException("The elementId property is missing from the dictionary, the dictionary cannot be converted into a TextualRepresentation");
            }
            string elementIdFeature = Convert.ToString(elementIdObject);

            if (!dictionary.TryGetValue("isImpliedIncluded", out object isImpliedIncludedObject))
            {
                throw new ArgumentException("The isImpliedIncluded property is missing from the dictionary, the dictionary cannot be converted into a TextualRepresentation");
            }
            bool isImpliedIncludedFeature = Convert.ToBoolean(isImpliedIncludedObject);

            if (!dictionary.TryGetValue("language", out object languageObject))
            {
                throw new ArgumentException("The language property is missing from the dictionary, the dictionary cannot be converted into a TextualRepresentation");
            }
            string languageFeature = Convert.ToString(languageObject);

            if (!dictionary.TryGetValue("name", out object nameObject))
            {
                throw new ArgumentException("The name property is missing from the dictionary, the dictionary cannot be converted into a TextualRepresentation");
            }
            string nameFeature = nameObject == null ? null : Convert.ToString(nameObject);

            if (!dictionary.TryGetValue("ownedRelationship", out object ownedRelationshipObject))
            {
                throw new ArgumentException("The ownedRelationship property is missing from the dictionary, the dictionary cannot be converted into a TextualRepresentation");
            }
            List<Guid> ownedRelationshipFeature = (ownedRelationshipObject as List<string>)?.Select(Guid.Parse).ToList();

            if (!dictionary.TryGetValue("owningRelationship", out object owningRelationshipObject))
            {
                throw new ArgumentException("The owningRelationship property is missing from the dictionary, the dictionary cannot be converted into a TextualRepresentation");
            }
            Guid? owningRelationshipFeature = owningRelationshipObject == null ? (Guid?)null : Guid.Parse(Convert.ToString(owningRelationshipObject));

            if (!dictionary.TryGetValue("shortName", out object shortNameObject))
            {
                throw new ArgumentException("The shortName property is missing from the dictionary, the dictionary cannot be converted into a TextualRepresentation");
            }
            string shortNameFeature = shortNameObject == null ? null : Convert.ToString(shortNameObject);


            textualRepresentationInstance.AliasIds = aliasIdsFeature ?? new List<string>();
            textualRepresentationInstance.Annotation = annotationFeature ?? new List<Guid>();
            textualRepresentationInstance.Body = bodyFeature;
            textualRepresentationInstance.ElementId = elementIdFeature;
            textualRepresentationInstance.IsImpliedIncluded = isImpliedIncludedFeature;
            textualRepresentationInstance.Language = languageFeature;
            textualRepresentationInstance.Name = nameFeature;
            textualRepresentationInstance.OwnedRelationship = ownedRelationshipFeature ?? new List<Guid>();
            textualRepresentationInstance.OwningRelationship = owningRelationshipFeature;
            textualRepresentationInstance.ShortName = shortNameFeature;

            return textualRepresentationInstance;
        }

        /// <summary>
        /// Reads a <see cref="ITextualRepresentation"/> from a <see cref="Dictionary{String, Object}"/> that contains a key-value-pair
        /// for each property.
        /// </summary>
        /// <param name="dictionary">
        /// The subject <see cref="Dictionary{String, Object}"/> that is to be converted into a <see cref="ITextualRepresentation"/>
        /// </param>
        /// <returns>
        /// An instance of <see cref="ITextualRepresentation"/>
        /// </returns>
        private static ITextualRepresentation ReadComplex(Dictionary<string, object> dictionary)
        {
            var textualRepresentationInstance = DictionaryNullAndTypeCheck(dictionary);

            if (!dictionary.TryGetValue("aliasIds", out object aliasIdsObject))
            {
                throw new ArgumentException("The aliasIds property is missing from the dictionary, the dictionary cannot be converted into a TextualRepresentation");
            }
            List<string> aliasIdsFeature = aliasIdsObject as List<string>;

            if (!dictionary.TryGetValue("annotation", out object annotationObject))
            {
                throw new ArgumentException("The annotation property is missing from the dictionary, the dictionary cannot be converted into a TextualRepresentation");
            }
            List<Guid> annotationFeature = (annotationObject as List<Guid>);

            if (!dictionary.TryGetValue("body", out object bodyObject))
            {
                throw new ArgumentException("The body property is missing from the dictionary, the dictionary cannot be converted into a TextualRepresentation");
            }
            string bodyFeature = Convert.ToString(bodyObject);

            if (!dictionary.TryGetValue("elementId", out object elementIdObject))
            {
                throw new ArgumentException("The elementId property is missing from the dictionary, the dictionary cannot be converted into a TextualRepresentation");
            }
            string elementIdFeature = Convert.ToString(elementIdObject);

            if (!dictionary.TryGetValue("isImpliedIncluded", out object isImpliedIncludedObject))
            {
                throw new ArgumentException("The isImpliedIncluded property is missing from the dictionary, the dictionary cannot be converted into a TextualRepresentation");
            }
            bool isImpliedIncludedFeature = Convert.ToBoolean(isImpliedIncludedObject);

            if (!dictionary.TryGetValue("language", out object languageObject))
            {
                throw new ArgumentException("The language property is missing from the dictionary, the dictionary cannot be converted into a TextualRepresentation");
            }
            string languageFeature = Convert.ToString(languageObject);

            if (!dictionary.TryGetValue("name", out object nameObject))
            {
                throw new ArgumentException("The name property is missing from the dictionary, the dictionary cannot be converted into a TextualRepresentation");
            }
            string nameFeature = nameObject == null ? null : Convert.ToString(nameObject);

            if (!dictionary.TryGetValue("ownedRelationship", out object ownedRelationshipObject))
            {
                throw new ArgumentException("The ownedRelationship property is missing from the dictionary, the dictionary cannot be converted into a TextualRepresentation");
            }
            List<Guid> ownedRelationshipFeature = (ownedRelationshipObject as List<Guid>);

            if (!dictionary.TryGetValue("owningRelationship", out object owningRelationshipObject))
            {
                throw new ArgumentException("The owningRelationship property is missing from the dictionary, the dictionary cannot be converted into a TextualRepresentation");
            }
            Guid? owningRelationshipFeature = (Guid?)owningRelationshipObject;

            if (!dictionary.TryGetValue("shortName", out object shortNameObject))
            {
                throw new ArgumentException("The shortName property is missing from the dictionary, the dictionary cannot be converted into a TextualRepresentation");
            }
            string shortNameFeature = shortNameObject == null ? null : Convert.ToString(shortNameObject);


            textualRepresentationInstance.AliasIds = aliasIdsFeature ?? new List<string>();
            textualRepresentationInstance.Annotation = annotationFeature ?? new List<Guid>();
            textualRepresentationInstance.Body = bodyFeature;
            textualRepresentationInstance.ElementId = elementIdFeature;
            textualRepresentationInstance.IsImpliedIncluded = isImpliedIncludedFeature;
            textualRepresentationInstance.Language = languageFeature;
            textualRepresentationInstance.Name = nameFeature;
            textualRepresentationInstance.OwnedRelationship = ownedRelationshipFeature ?? new List<Guid>();
            textualRepresentationInstance.OwningRelationship = owningRelationshipFeature;
            textualRepresentationInstance.ShortName = shortNameFeature;

            return textualRepresentationInstance;
        }

        /// <summary>
        /// Checks whether the <see cref="Dictionary{String, Object}"/> is not null and whether it is
        /// of type <see cref="TextualRepresentation"/>
        /// </summary>
        /// <param name="dictionary">
        /// The subject <see cref="Dictionary{String, Object}"/> that contains the key-value pairs of
        /// properties and values.
        /// </param>
        /// <returns>
        /// an instance of <see cref="ITextualRepresentation"/>
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="dictionary"/> is null
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="dictionary"/> is not of type <see cref="TextualRepresentation"/>
        /// </exception>
        private static ITextualRepresentation DictionaryNullAndTypeCheck(Dictionary<string, object> dictionary)
        {
            if (dictionary == null)
            {
                throw new ArgumentNullException("dictionary", "The dictionary may not be null");
            }

            if (!dictionary.TryGetValue("@type", out object typeObject))
            {
                throw new ArgumentException("The type property is missing from the dictionary, the dictionary cannot be converted into a TextualRepresentation");
            }

            var type = Convert.ToString(typeObject);

            if (type != "TextualRepresentation")
            {
                throw new ArgumentException($"The dictionary contains an Object is of type {type} and can therefore not be converted into a TextualRepresentation");
            }

            if (!dictionary.TryGetValue("@id", out object idObject))
            {
                throw new ArgumentException("The id property is missing from the dictionary, the dictionary cannot be converted into a TextualRepresentation");
            }
            var id = Guid.Parse(Convert.ToString(idObject));

            var textualRepresentationInstance = new Core.DTO.TextualRepresentation
            {
                Id = id
            };

            return textualRepresentationInstance;
        }
    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------