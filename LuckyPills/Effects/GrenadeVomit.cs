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
    using LuckyPills.API;
    using LuckyPills.Models;
    using MEC;

    /// <inheritdoc />
    public class GrenadeVomit : PillEffect
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GrenadeVomit"/> class.
        /// </summary>
        public GrenadeVomit()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GrenadeVomit"/> class.
        /// </summary>
        /// <param name="grenadeType"><inheritdoc cref="GrenadeType"/></param>
        public GrenadeVomit(ProjectileType grenadeType) => GrenadeType = grenadeType;

        /// <inheritdoc />
        public override int Id { get; set; } = 11;

        /// <inheritdoc />
        public override bool IsEnabled { get; set; } = true;

        /// <inheritdoc />
        public override string Translation { get; set; } = "Du da Granaten für {duration} Sekunden!";

        /// <inheritdoc />
        public override Duration Duration { get; set; } = new(3, 3);

        /// <inheritdoc />
        public override int Weight { get; set; } = 1;

        /// <summary>
        /// Gets or sets the type of grenade to use.
        /// </summary>
        public ProjectileType GrenadeType { get; set; } = ProjectileType.Flashbang;

        /// <summary>
        /// Gets or sets the amount of grenades a player should eject per second.
        /// </summary>
        public int GrenadesPerSecond { get; set; } = 1;

        /// <inheritdoc />
        protected override void OnEnabled(Player player, int duration)
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

                player.ThrowGrenade(GrenadeType);
                yield return Timing.WaitForSeconds(delayTime);
            }
        }
    }
}