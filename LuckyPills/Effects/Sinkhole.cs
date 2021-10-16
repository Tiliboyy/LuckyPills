// -----------------------------------------------------------------------
// <copyright file="Sinkhole.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace LuckyPills.Effects
{
    using Exiled.API.Features;
    using LuckyPills.API.Features;

    /// <inheritdoc />
    public class Sinkhole : PillEffect
    {
        /// <inheritdoc />
        public override bool IsEnabled { get; set; } = true;

        /// <inheritdoc />
        public override string Translation { get; set; } = "You've been given a sinkhole effect for {duration} seconds";

        /// <inheritdoc />
        public override int MinimumDuration { get; set; } = 10;

        /// <inheritdoc />
        public override int MaximumDuration { get; set; } = 20;

        /// <inheritdoc />
        public override int Odds { get; set; } = 1;

        /// <inheritdoc />
        public override void RunEffect(Player player, int duration)
        {
            player.EnableEffect<CustomPlayerEffects.SinkHole>(duration);
        }
    }
}