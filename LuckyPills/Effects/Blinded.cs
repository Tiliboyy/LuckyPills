﻿// -----------------------------------------------------------------------
// <copyright file="Blinded.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace LuckyPills.Effects
{
    using Exiled.API.Features;
    using LuckyPills.Interfaces;

    /// <inheritdoc />
    public class Blinded : IPillEffect
    {
        /// <inheritdoc />
        public bool IsEnabled { get; set; } = true;

        /// <inheritdoc />
        public string Translation { get; set; } = "You've been blinded for {duration} seconds";

        /// <inheritdoc />
        public int MinimumDuration { get; set; } = 10;

        /// <inheritdoc />
        public int MaximumDuration { get; set; } = 20;

        /// <inheritdoc />
        public void RunEffect(Player player, int duration)
        {
            player.EnableEffect<CustomPlayerEffects.Blinded>(duration);
        }
    }
}