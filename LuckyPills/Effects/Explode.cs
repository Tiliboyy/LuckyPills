// -----------------------------------------------------------------------
// <copyright file="Explode.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace LuckyPills.Effects
{
    using LuckyPills.Interfaces;
    using YamlDotNet.Serialization;

    /// <inheritdoc />
    public class Explode : IPillEffect
    {
        /// <inheritdoc />
        public bool IsEnabled { get; set; } = true;

        /// <inheritdoc />
        public string Translation { get; set; } = "You've spontaneously combusted";

        /// <inheritdoc />
        [YamlIgnore]
        public int MinimumDuration { get; set; }

        /// <inheritdoc />
        [YamlIgnore]
        public int MaximumDuration { get; set; }
    }
}