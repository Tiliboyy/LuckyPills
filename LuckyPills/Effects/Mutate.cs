// -----------------------------------------------------------------------
// <copyright file="Mutate.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

using PlayerRoles;

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
        private readonly Dictionary<Player, RoleTypeId> cachedRoles = new();

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
            player.Role.Set(RoleTypeId.Scp0492, SpawnReason.ForceClass, RoleSpawnFlags.None);
        }

        /// <inheritdoc />
        protected override void OnDisabled(Player player)
        {
            if (!player.IsDead && cachedRoles.TryGetValue(player, out RoleTypeId role))
                player.Role.Set(role, SpawnReason.ForceClass, RoleSpawnFlags.None);
        }
    }
}