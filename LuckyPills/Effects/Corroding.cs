// -----------------------------------------------------------------------
// <copyright file="Corroding.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace LuckyPills.Effects
{
    using Exiled.API.Features;
    using LuckyPills.API;
    using LuckyPills.Models;
    using YamlDotNet.Serialization;

    /// <inheritdoc />
    public class Corroding : PillEffect
    {
        /// <inheritdoc />
        public override int Id { get; set; } = 5;

        /// <inheritdoc />
        public override bool IsEnabled { get; set; } = true;

        /// <inheritdoc />
        public override string Translation { get; set; } = "You've been sent to the pocket dimension";

        /// <inheritdoc />
        [YamlIgnore]
        public override Duration Duration { get; set; }

        /// <inheritdoc />
        public override int Weight { get; set; } = 1;

        /// <inheritdoc />
        protected override void OnEnabled(Player player, int duration)
        {
            player.EnableEffect<CustomPlayerEffects.Corroding>();
        }
    }
}