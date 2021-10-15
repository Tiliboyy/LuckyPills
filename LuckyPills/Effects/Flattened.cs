// -----------------------------------------------------------------------
// <copyright file="Flattened.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace LuckyPills.Effects
{
    using Exiled.API.Features;
    using LuckyPills.API;
    using MEC;
    using UnityEngine;

    /// <inheritdoc />
    public class Flattened : PillEffect
    {
        /// <inheritdoc />
        public override bool IsEnabled { get; set; } = true;

        /// <inheritdoc />
        public override string Translation { get; set; } = "You've been flattened for {duration} seconds";

        /// <inheritdoc />
        public override int MinimumDuration { get; set; } = 10;

        /// <inheritdoc />
        public override int MaximumDuration { get; set; } = 30;

        /// <inheritdoc />
        public override int Odds { get; set; } = 1;

        /// <inheritdoc/>
        public override void RunEffect(Player player, int duration)
        {
            player.Scale = new Vector3(1f, 0.5f, 1f);
            Timing.CallDelayed(duration, () => player.Scale = Vector3.one);
        }
    }
}