// -----------------------------------------------------------------------
// <copyright file="Invisible.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace LuckyPills.Effects
{
    using Exiled.API.Features;
    using LuckyPills.API.Features;

    /// <inheritdoc />
    public class Invisible : PillEffect
    {
        /// <inheritdoc />
        public override bool IsEnabled { get; set; } = true;

        /// <inheritdoc />
        public override string Translation { get; set; } = "You've been turned invisible for {duration} seconds";

        /// <inheritdoc />
        public override int MinimumDuration { get; set; } = 10;

        /// <inheritdoc />
        public override int MaximumDuration { get; set; } = 20;

        /// <inheritdoc />
        public override int Odds { get; set; } = 1;

        /// <inheritdoc />
        protected override void OnEnabled(Player player, int duration)
        {
            player.IsInvisible = true;
        }

        /// <inheritdoc />
        protected override void OnDisabled(Player player)
        {
            player.IsInvisible = false;
        }
    }
}