// -----------------------------------------------------------------------
// <copyright file="Invisible.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace LuckyPills.Effects
{
    using Exiled.API.Features;
    using LuckyPills.Interfaces;
    using MEC;

    /// <inheritdoc />
    public class Invisible : IPillEffect
    {
        /// <inheritdoc />
        public bool IsEnabled { get; set; } = true;

        /// <inheritdoc />
        public string Translation { get; set; } = "You've been turned invisible for {duration} seconds";

        /// <inheritdoc />
        public int MinimumDuration { get; set; } = 10;

        /// <inheritdoc />
        public int MaximumDuration { get; set; } = 20;

        /// <inheritdoc />
        public void RunEffect(Player player, int duration)
        {
            player.IsInvisible = true;
            Timing.CallDelayed(duration, () => player.IsInvisible = false);
        }
    }
}