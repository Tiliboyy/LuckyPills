// -----------------------------------------------------------------------
// <copyright file="UpsideDown.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

using CustomPlayerEffects;

namespace LuckyPills.Effects
{
    using Exiled.API.Features;
    using LuckyPills.API;
    using LuckyPills.Models;
    using UnityEngine;

    /// <inheritdoc />
    public class Speed : PillEffect
    {
        /// <inheritdoc />
        public override int Id { get; set; } = 28;

        /// <inheritdoc />
        public override bool IsEnabled { get; set; } = true;

        /// <inheritdoc />
        public override string Translation { get; set; } = "Du wurdest für {duration} Sekunden ein extrem schnell!";

        /// <inheritdoc />
        public override Duration Duration { get; set; } = new(5, 15);

        /// <inheritdoc />
        public override int Weight { get; set; } = 1;

        /// <inheritdoc />
        protected override void OnEnabled(Player player, int duration)
        {
            player.ChangeEffectIntensity<MovementBoost>(255, duration);
        }


    }
}