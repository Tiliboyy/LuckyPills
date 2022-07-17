// -----------------------------------------------------------------------
// <copyright file="Explode.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace LuckyPills.Effects
{
    using Exiled.API.Features;
    using Exiled.API.Features.Items;
    using LuckyPills.API;
    using LuckyPills.Models;
    using YamlDotNet.Serialization;

    /// <inheritdoc />
    public class Explode : PillEffect
    {
        /// <inheritdoc />
        public override int Id { get; set; } = 7;

        /// <inheritdoc />
        public override bool IsEnabled { get; set; } = true;

        /// <inheritdoc />
        public override string Translation { get; set; } = "You've spontaneously combusted";

        /// <inheritdoc />
        [YamlIgnore]
        public override Duration Duration { get; set; }

        /// <inheritdoc />
        public override int Weight { get; set; } = 1;

        /// <inheritdoc />
        protected override void OnEnabled(Player player, int duration)
        {
            ExplosiveGrenade explosiveGrenade = (ExplosiveGrenade)Item.Create(ItemType.GrenadeHE);
            explosiveGrenade.FuseTime = 0.1f;
            explosiveGrenade.SpawnActive(player.Position, player);
        }
    }
}