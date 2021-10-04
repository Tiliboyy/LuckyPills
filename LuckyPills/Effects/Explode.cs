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
    using LuckyPills.Interfaces;
    using YamlDotNet.Serialization;

    /// <inheritdoc />
    public class Explode : IPillEffect
    {
        /// <inheritdoc />
        public bool IsEnabled { get; set; } = true;

        /// <inheritdoc />
        public string Translation { get; set; } = "You've spontaneously combusted";

        /// <inheritdoc />
        [YamlIgnore]
        public int MinimumDuration { get; set; }

        /// <inheritdoc />
        [YamlIgnore]
        public int MaximumDuration { get; set; }

        /// <inheritdoc />
        public void RunEffect(Player player, int duration)
        {
            new ExplosiveGrenade(ItemType.GrenadeHE, player) { FuseTime = 0.1f }.SpawnActive(player.Position, player);
        }
    }
}