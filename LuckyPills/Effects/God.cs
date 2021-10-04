// -----------------------------------------------------------------------
// <copyright file="God.cs" company="Build">
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
    public class God : IPillEffect
    {
        /// <inheritdoc />
        public bool IsEnabled { get; set; } = true;

        /// <inheritdoc />
        public string Translation { get; set; } = "You've been given god mode for {duration} seconds";

        /// <inheritdoc />
        public int MinimumDuration { get; set; } = 5;

        /// <inheritdoc />
        public int MaximumDuration { get; set; } = 20;

        /// <inheritdoc />
        public void RunEffect(Player player, int duration)
        {
            player.IsGodModeEnabled = true;
            Timing.CallDelayed(duration, () => player.IsGodModeEnabled = false);
        }
    }
}