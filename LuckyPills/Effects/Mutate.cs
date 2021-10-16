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
    using LuckyPills.API.Features;
    using MEC;
    using MonoMod.Utils;

    /// <inheritdoc />
    public class Mutate : PillEffect
    {
        /// <inheritdoc />
        public override bool IsEnabled { get; set; } = true;

        /// <inheritdoc/>
        public override string Translation { get; set; } = "You've been mutated for {duration} seconds";

        /// <inheritdoc />
        public override int MinimumDuration { get; set; } = 5;

        /// <inheritdoc />
        public override int MaximumDuration { get; set; } = 30;

        /// <inheritdoc />
        public override int Odds { get; set; } = 1;

        /// <inheritdoc />
        public override void RunEffect(Player player, int duration)
        {
            RoleType cachedMutatorRole = player.Role;
            Dictionary<ItemType, ushort> ammo = player.Ammo;
            player.DropItems();
            player.SetRole(RoleType.Scp0492, SpawnReason.ForceClass, true);
            Timing.CallDelayed(duration, () =>
            {
                if (player.IsDead)
                    return;

                player.SetRole(cachedMutatorRole, SpawnReason.ForceClass, true);
                player.Ammo.AddRange(ammo);
            });
        }
    }
}