﻿// -----------------------------------------------------------------------
// <copyright file="Amnesia.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace LuckyPills.Effects
{
    using Exiled.API.Features;
    using LuckyPills.Interfaces;

    /// <inheritdoc />
    public class Amnesia : IPillEffect
    {
        /// <inheritdoc />
        public bool IsEnabled { get; set; } = true;

        /// <inheritdoc />
        public string Translation { get; set; } = "You've been given amnesia for {duration} seconds";

        /// <inheritdoc />
        public int MinimumDuration { get; set; } = 10;

        /// <inheritdoc />
        public int MaximumDuration { get; set; } = 20;

        /// <inheritdoc />
        public void RunEffect(Player player, int duration)
        {
            player.EnableEffect<CustomPlayerEffects.Amnesia>(duration);
        }
    }
}