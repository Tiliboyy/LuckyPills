// -----------------------------------------------------------------------
// <copyright file="OnActivatingPainkillers.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace LuckyPills.Patches
{
#pragma warning disable SA1313
    using Exiled.API.Features;
    using HarmonyLib;
    using InventorySystem.Items.Usables;
    using LuckyPills.API;

    /// <summary>
    /// Patches <see cref="Painkillers.OnEffectsActivated"/> to override normal painkiller effects with random effects.
    /// </summary>
    [HarmonyPatch(typeof(Painkillers), nameof(Painkillers.OnEffectsActivated))]
    internal static class OnActivatingPainkillers
    {
        private static bool Prefix(Painkillers __instance)
        {
            PillEffect.RunRandom(Player.Get(__instance.Owner));
            return false;
        }
    }
}