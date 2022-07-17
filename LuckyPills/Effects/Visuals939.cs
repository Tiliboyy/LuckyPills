// -----------------------------------------------------------------------
// <copyright file="Visuals939.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace LuckyPills.Effects
{
    using System.ComponentModel;
    using Exiled.API.Enums;
    using Exiled.API.Features;
    using LuckyPills.API;
    using LuckyPills.Models;

    /// <inheritdoc />
    public class Visuals939 : PillEffect
    {
        /// <inheritdoc />
        public override int Id { get; set; } = 21;

        /// <inheritdoc />
        public override bool IsEnabled { get; set; } = true;

        /// <inheritdoc />
        public override string Translation { get; set; } = "You've been given doge vision for {duration} seconds";

        /// <inheritdoc />
        public override Duration Duration { get; set; } = new(10, 20);

        /// <inheritdoc />
        public override int Weight { get; set; } = 1;

        /// <summary>
        /// Gets or sets the type of Scp939 visuals to give.
        /// </summary>
        [Description("The type of Scp939 visuals to give.")]
        public byte Intensity { get; set; } = 1;

        /// <inheritdoc />
        protected override void OnEnabled(Player player, int duration)
        {
            player.EnableEffect<CustomPlayerEffects.Visuals939>(duration);
            player.GetEffect(EffectType.Visuals939).Intensity = Intensity;
        }

        /// <inheritdoc />
        protected override void OnDisabled(Player player)
        {
            player.DisableEffect<CustomPlayerEffects.Visuals939>();
        }
    }
}