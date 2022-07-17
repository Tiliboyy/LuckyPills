// -----------------------------------------------------------------------
// <copyright file="Mutate.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace LuckyPills.Effects
{
    using System.Collections.Generic;
    using Exiled.API.Enums;
    using Exiled.API.Features;
    using LuckyPills.API;
    using LuckyPills.Models;

    /// <inheritdoc />
    public class Mutate : PillEffect
    {
        private readonly Dictionary<Player, RoleType> cachedRoles = new();

        /// <inheritdoc />
        public override int Id { get; set; } = 16;

        /// <inheritdoc />
        public override bool IsEnabled { get; set; } = true;

        /// <inheritdoc/>
        public override string Translation { get; set; } = "You've been mutated for {duration} seconds";

        /// <inheritdoc />
        public override Duration Duration { get; set; } = new(5, 30);

        /// <inheritdoc />
        public override int Weight { get; set; } = 1;

        /// <inheritdoc />
        protected override void OnEnabled(Player player, int duration)
        {
            cachedRoles[player] = player.Role;
            player.DropItems();
            player.SetRole(RoleType.Scp0492, SpawnReason.ForceClass, true);
        }

        /// <inheritdoc />
        protected override void OnDisabled(Player player)
        {
            if (!player.IsDead && cachedRoles.TryGetValue(player, out RoleType role))
                player.SetRole(role, SpawnReason.ForceClass, true);
        }
    }
}