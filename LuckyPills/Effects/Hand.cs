// -----------------------------------------------------------------------
// <copyright file="God.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

using CustomPlayerEffects;

namespace LuckyPills.Effects
{
    using Exiled.API.Features;
    using LuckyPills.API;
    using LuckyPills.Models;

    /// <inheritdoc />
    public class Hand : PillEffect
    {
        /// <inheritdoc />
        public override int Id { get; set; } = 22;

        /// <inheritdoc />
        public override bool IsEnabled { get; set; } = true;

        /// <inheritdoc />
        public override string Translation { get; set; } = "Du hast deine Hände verloren!";

        /// <inheritdoc />
        public override Duration Duration { get; set; }

        /// <inheritdoc />
        public override int Weight { get; set; } = 1;

        /// <inheritdoc />
        protected override void OnEnabled(Player player, int duration)
        {
            player.EnableEffect<SeveredHands>(1f);
        }
    }
}