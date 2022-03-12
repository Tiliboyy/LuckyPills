// -----------------------------------------------------------------------
// <copyright file="UpsideDown.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace LuckyPills.Effects
{
    using Exiled.API.Features;
    using LuckyPills.API.Features;
    using UnityEngine;

    /// <inheritdoc />
    public class UpsideDown : PillEffect
    {
        /// <inheritdoc />
        public override bool IsEnabled { get; set; } = true;

        /// <inheritdoc />
        public override string Translation { get; set; } = "You've been converted to australian for {duration} seconds";

        /// <inheritdoc />
        public override int MinimumDuration { get; set; } = 5;

        /// <inheritdoc />
        public override int MaximumDuration { get; set; } = 30;

        /// <inheritdoc />
        public override int Odds { get; set; } = 1;

        /// <inheritdoc />
        protected override void OnEnabled(Player player, int duration)
        {
            player.Scale = new Vector3(1f, -1f, 1f);
        }

        /// <inheritdoc />
        protected override void OnDisabled(Player player)
        {
            player.Position += Vector3.up;
            player.Scale = Vector3.one;
        }
    }
}