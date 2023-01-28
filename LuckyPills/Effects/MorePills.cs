﻿// -----------------------------------------------------------------------
// <copyright file="Poisoned.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

using MEC;

namespace LuckyPills.Effects
{
    using Exiled.API.Features;
    using LuckyPills.API;
    using LuckyPills.Models;

    /// <inheritdoc />
    public class MorePills : PillEffect
    {
        /// <inheritdoc />
        public override int Id { get; set; } = 18;
        


        /// <inheritdoc />
        public override bool IsEnabled { get; set; } = true;

        /// <inheritdoc />
        public override string Translation { get; set; } = $"Du hast mehr Pillen erhalten!";

        /// <inheritdoc />
        public override Duration Duration { get; set; }

        /// <inheritdoc />
        public override int Weight { get; set; } = 1;

        /// <inheritdoc />
        protected override void OnEnabled(Player player, int duration)
        {
            Timing.CallDelayed(1f, () =>
            {
                while (!player.IsInventoryFull)
                {
                    player.AddItem(ItemType.Painkillers);
                }
            });


        }
    }
}