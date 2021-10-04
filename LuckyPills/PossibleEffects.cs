// -----------------------------------------------------------------------
// <copyright file="PossibleEffects.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace LuckyPills
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Exiled.API.Enums;
    using Exiled.API.Features;
    using Exiled.API.Features.Items;
    using LuckyPills.Interfaces;
    using MEC;
    using MonoMod.Utils;
    using UnityEngine;

    /// <summary>
    /// Handles the configured effects and their actions.
    /// </summary>
    public class PossibleEffects
    {
        private readonly Dictionary<IPillEffect, Action<Player, float>> effects;
        private readonly System.Random random;

        /// <summary>
        /// Initializes a new instance of the <see cref="PossibleEffects"/> class.
        /// </summary>
        /// <param name="plugin">An instance of the plugin class.</param>
        public PossibleEffects(Plugin plugin)
        {
            effects = new Dictionary<IPillEffect, Action<Player, float>>
            {
                [plugin.Config.Explode] = Explode,
                [plugin.Config.Flattened] = Flattened,
                [plugin.Config.God] = God,
                [plugin.Config.GrenadeVomit] = GrenadeVomit,
                [plugin.Config.Mutate] = Mutate,
                [plugin.Config.Paper] = Paper,
                [plugin.Config.UpsideDown] = UpsideDown,
            };

            random = Exiled.Loader.Loader.Random;
        }

        /// <summary>
        /// Gets a random effect from the configured effects.
        /// </summary>
        /// <returns>The configured effect and action.</returns>
        public KeyValuePair<IPillEffect, Action<Player, float>> GetRandomEffect()
        {
            return effects.Where(kvp => kvp.Key.IsEnabled).ElementAt(random.Next(effects.Count));
        }

        private void Explode(Player player, float duration)
        {
            new ExplosiveGrenade(ItemType.GrenadeHE, player) { FuseTime = 0.1f }.SpawnActive(player.Position, player);
        }

        private void God(Player player, float duration)
        {
            player.IsGodModeEnabled = true;
            Timing.CallDelayed(duration, () => player.IsGodModeEnabled = false);
        }

        private void Flattened(Player player, float duration)
        {
            player.Scale = new Vector3(1f, 0.5f, 1f);
            Timing.CallDelayed(duration, () => player.Scale = Vector3.one);
        }

        private void GrenadeVomit(Player player, float duration)
        {
            Timing.RunCoroutine(RunGrenadeVomit(player, duration));
        }

        private void Mutate(Player player, float duration)
        {
            RoleType cachedMutatorRole = player.Role;
            Dictionary<ItemType, ushort> ammo = player.Ammo;
            player.DropItems();
            player.SetRole(RoleType.Scp0492, SpawnReason.ForceClass, true);
            Timing.CallDelayed(duration, () =>
            {
                player.SetRole(cachedMutatorRole, SpawnReason.ForceClass, true);
                player.Ammo.AddRange(ammo);
            });
        }

        private void Paper(Player player, float duration)
        {
            player.Scale = new Vector3(1f, 1f, 0.01f);
            Timing.CallDelayed(duration, () => player.Scale = Vector3.one);
        }

        private void UpsideDown(Player player, float duration)
        {
            player.Scale = new Vector3(1f, -1f, 1f);
            Timing.CallDelayed(duration, () => player.Scale = Vector3.one);
        }

        private IEnumerator<float> RunGrenadeVomit(Player player, float duration)
        {
            for (int i = 0; i < duration * 10; i++)
            {
                if (!player.IsAlive)
                    yield break;

                // new ExplosiveGrenade(ItemType.GrenadeHE, player).SpawnActive(player.Position, player);
                player.ThrowGrenade(GrenadeType.FragGrenade);
                yield return Timing.WaitForSeconds(0.1f);
            }
        }
    }
}