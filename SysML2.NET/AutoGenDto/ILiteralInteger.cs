// -------------------------------------------------------------------------------------------------
// <copyright file="ILiteralInteger.cs" company="RHEA System S.A.">
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

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------

namespace SysML2.NET.DTO
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// A LiteralInteger is a LiteralExpression that provides an Integer value as a result. It must have an
    /// owned result parameter whose type is Integer.An Expression that provides an Integer value as a
    /// result.A LiteralInteger must be typed by a specialization of Evaluation with no input parameters and
    /// a single Integer value as its result.
    /// </summary>
    public partial interface ILiteralInteger : ILiteralExpression
    {
        /// <summary>
        /// The Integer value that is the result of evaluating this Expression.The Integer value that is the
        /// result of evaluating this Expression.
        /// </summary>
        int Value { get; set; }

    }
}

// ------------------------------------------------------------------------------------------------
// --------THIS IS AN AUTOMATICALLY GENERATED FILE. ANY MANUAL CHANGES WILL BE OVERWRITTEN!--------
// ------------------------------------------------------------------------------------------------