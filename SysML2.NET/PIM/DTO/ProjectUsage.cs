﻿// -------------------------------------------------------------------------------------------------
// <copyright file="ProjectUsage.cs" company="Starion Group S.A.">
// 
//   Copyright 2022-2024 Starion Group S.A.
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

namespace SysML2.NET.PIM.DTO
{
    using System;

    using SysML2.NET.Common;

    /// <summary>
    /// a realization of <see cref="IData"/> that represents the use of a <see cref="Project"/> in the context of another
    /// <see cref="Project"/>.
    /// </summary>
    public class ProjectUsage : IData
    {
        /// <summary>
        /// Gets or sets the unique identifier
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the reference to the <see cref="Commit"/> of the <see cref="Project"/> being used.
        /// </summary>
        public Guid UsedCommit { get; set; }

        /// <summary>
        /// Gets or sets the reference to the <see cref="Projec"/> of the <see cref="Project"/> being used.
        /// </summary>
        public Guid UsedProject { get; set; }
    }
}
