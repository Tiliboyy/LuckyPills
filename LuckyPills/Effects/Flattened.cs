// -----------------------------------------------------------------------
// <copyright file="Flattened.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace LuckyPills.Effects
{
    using Exiled.API.Features;
    using LuckyPills.API;
    using LuckyPills.Models;
    using UnityEngine;

    /// <inheritdoc />
    public class Flattened : PillEffect
    {
        /// <inheritdoc />
        public override int Id { get; set; } = 9;

        /// <inheritdoc />
        public override bool IsEnabled { get; set; } = true;

        /// <inheritdoc />
        public override string Translation { get; set; } = "Du wurdest für {duration} Sekunden flach!";

        /// <inheritdoc />
        public override Duration Duration { get; set; } = new(10, 30);

        /// <inheritdoc />
        public override int Weight { get; set; } = 1;

        /// <inheritdoc/>
        protected override void OnEnabled(Player player, int duration)
        {
            player.Scale = new Vector3(1f, 0.5f, 1f);
        }

        /// <inheritdoc />
        protected override void OnDisabled(Player player)
        {
            player.Scale = Vector3.one;
        }
    }
}