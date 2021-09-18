// -----------------------------------------------------------------------
// <copyright file="UpsideDown.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace LuckyPills.Effects
{
    using LuckyPills.Interfaces;

    /// <inheritdoc />
    public class UpsideDown : IPillEffect
    {
        /// <inheritdoc />
        public string Translation { get; set; }

        /// <inheritdoc />
        public int MinimumDuration { get; set; }

        /// <inheritdoc />
        public int MaximumDuration { get; set; }
    }
}