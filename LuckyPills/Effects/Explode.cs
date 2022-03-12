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
    using LuckyPills.API.Features;
    using YamlDotNet.Serialization;

    /// <inheritdoc />
    public class Explode : PillEffect
    {
        /// <inheritdoc />
        public override bool IsEnabled { get; set; } = true;

        /// <inheritdoc />
        public override string Translation { get; set; } = "You've spontaneously combusted";

        /// <inheritdoc />
        [YamlIgnore]
        public override int MinimumDuration { get; set; }

        /// <inheritdoc />
        [YamlIgnore]
        public override int MaximumDuration { get; set; }

        /// <inheritdoc />
        public override int Odds { get; set; } = 1;

        /// <inheritdoc />
        protected override void OnEnabled(Player player, int duration)
        {
            ExplosiveGrenade explosiveGrenade = (ExplosiveGrenade)Item.Create(ItemType.GrenadeHE);
            explosiveGrenade.FuseTime = 0.1f;
            explosiveGrenade.SpawnActive(player.Position, player);
        }
    }
}