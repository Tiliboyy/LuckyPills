// -----------------------------------------------------------------------
// <copyright file="Hemorrhage.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace LuckyPills.Effects
{
    using Exiled.API.Features;
    using LuckyPills.API;
    using LuckyPills.Models;

    /// <inheritdoc />
    public class Hemorrhage : PillEffect
    {
        /// <inheritdoc />
        public override int Id { get; set; } = 14;

        /// <inheritdoc />
        public override bool IsEnabled { get; set; } = true;

        /// <inheritdoc />
        public override string Translation { get; set; } = "You've begun to hemorrhage for the next {duration} seconds";

        /// <inheritdoc />
        public override Duration Duration { get; set; } = new(10, 20);

        /// <inheritdoc />
        public override int Weight { get; set; } = 1;

        /// <inheritdoc />
        protected override void OnEnabled(Player player, int duration)
        {
            player.EnableEffect<CustomPlayerEffects.Hemorrhage>(duration);
        }

        /// <inheritdoc />
        protected override void OnDisabled(Player player)
        {
            player.DisableEffect<CustomPlayerEffects.Hemorrhage>();
        }
    }
}