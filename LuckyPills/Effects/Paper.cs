// -----------------------------------------------------------------------
// <copyright file="Paper.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace LuckyPills.Effects
{
    using LuckyPills.Interfaces;

    /// <inheritdoc />
    public class Paper : IPillEffect
    {
        /// <inheritdoc />
        public bool IsEnabled { get; set; } = true;

        /// <inheritdoc/>
        public string Translation { get; set; } = "You've been turned into paper for {duration} seconds";

        /// <inheritdoc />
        public int MinimumDuration { get; set; } = 5;

        /// <inheritdoc />
        public int MaximumDuration { get; set; } = 30;
    }
}