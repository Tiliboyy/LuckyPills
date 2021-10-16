// -----------------------------------------------------------------------
// <copyright file="Visuals939.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace LuckyPills.Effects
{
    using Exiled.API.Enums;
    using Exiled.API.Features;
    using LuckyPills.API.Features;

    /// <inheritdoc />
    public class Visuals939 : PillEffect
    {
        /// <inheritdoc />
        public override bool IsEnabled { get; set; } = true;

        /// <inheritdoc />
        public override string Translation { get; set; } = "You've been given doge vision for {duration} seconds";

        /// <inheritdoc />
        public override int MinimumDuration { get; set; } = 10;

        /// <inheritdoc />
        public override int MaximumDuration { get; set; } = 20;

        /// <inheritdoc />
        public override int Odds { get; set; } = 1;

        /// <summary>
        /// Gets or sets the type of Scp939 visuals to give.
        /// </summary>
        public byte Intensity { get; set; } = 1;

        /// <inheritdoc />
        public override void RunEffect(Player player, int duration)
        {
            player.EnableEffect<CustomPlayerEffects.Visuals939>(duration);
            player.GetEffect(EffectType.Visuals939).Intensity = Intensity;
        }
    }
}