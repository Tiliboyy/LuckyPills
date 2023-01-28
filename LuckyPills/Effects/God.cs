// -----------------------------------------------------------------------
// <copyright file="God.cs" company="Build">
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
    public class God : PillEffect
    {
        /// <inheritdoc />
        public override int Id { get; set; } = 10;

        /// <inheritdoc />
        public override bool IsEnabled { get; set; } = true;

        /// <inheritdoc />
        public override string Translation { get; set; } = "Du hast für {duration} Sekunden God Mode!";

        /// <inheritdoc />
        public override Duration Duration { get; set; } = new(5, 20);

        /// <inheritdoc />
        public override int Weight { get; set; } = 1;

        /// <inheritdoc />
        protected override void OnEnabled(Player player, int duration)
        {
            player.IsGodModeEnabled = true;
        }

        /// <inheritdoc />
        protected override void OnDisabled(Player player)
        {
            player.IsGodModeEnabled = false;
        }
    }
}