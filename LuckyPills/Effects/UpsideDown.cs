// -----------------------------------------------------------------------
// <copyright file="UpsideDown.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace LuckyPills.Effects
{
    using Exiled.API.Features;
    using LuckyPills.Interfaces;
    using MEC;
    using UnityEngine;

    /// <inheritdoc />
    public class UpsideDown : IPillEffect
    {
        /// <inheritdoc />
        public bool IsEnabled { get; set; } = true;

        /// <inheritdoc />
        public string Translation { get; set; } = "You've been converted to australian for {duration} seconds";

        /// <inheritdoc />
        public int MinimumDuration { get; set; } = 5;

        /// <inheritdoc />
        public int MaximumDuration { get; set; } = 30;

        /// <inheritdoc />
        public void RunEffect(Player player, int duration)
        {
            player.Scale = new Vector3(1f, -1f, 1f);
            Timing.CallDelayed(duration, () =>
            {
                player.Position += Vector3.up;
                player.Scale = Vector3.one;
            });
        }
    }
}