// -----------------------------------------------------------------------
// <copyright file="GrenadeVomit.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace LuckyPills.Effects
{
    using System.Collections.Generic;
    using Exiled.API.Enums;
    using Exiled.API.Features;
    using LuckyPills.Interfaces;
    using MEC;

    /// <inheritdoc />
    public class GrenadeVomit : IPillEffect
    {
        /// <inheritdoc />
        public bool IsEnabled { get; set; } = true;

        /// <inheritdoc />
        public string Translation { get; set; } = "You've been given bomb vomit for {duration} seconds";

        /// <inheritdoc />
        public int MinimumDuration { get; set; } = 10;

        /// <inheritdoc />
        public int MaximumDuration { get; set; } = 30;

        /// <summary>
        /// Gets or sets the amount of grenades a player should eject per second.
        /// </summary>
        public int GrenadesPerSecond { get; set; } = 10;

        /// <inheritdoc />
        public void RunEffect(Player player, int duration)
        {
            Timing.RunCoroutine(RunGrenadeVomit(player, duration));
        }

        private IEnumerator<float> RunGrenadeVomit(Player player, float duration)
        {
            float delayTime = 1f / GrenadesPerSecond;
            for (int i = 0; i < duration * GrenadesPerSecond; i++)
            {
                if (!player.IsAlive)
                    yield break;

                player.ThrowGrenade(GrenadeType.FragGrenade);
                yield return Timing.WaitForSeconds(delayTime);
            }
        }
    }
}