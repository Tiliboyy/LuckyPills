// -----------------------------------------------------------------------
// <copyright file="Flashed.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

 namespace LuckyPills.Effects
{
    using Exiled.API.Features;
    using LuckyPills.Interfaces;

    /// <inheritdoc />
    public class Flashed : IPillEffect
    {
        /// <inheritdoc />
        public bool IsEnabled { get; set; } = true;

        /// <inheritdoc />
        public string Translation { get; set; } = "You've been flashed";

        /// <inheritdoc />
        public int MinimumDuration { get; set; } = 5;

        /// <inheritdoc />
        public int MaximumDuration { get; set; } = 10;

        /// <inheritdoc />
        public void RunEffect(Player player, int duration)
        {
            player.EnableEffect<CustomPlayerEffects.Flashed>(duration);
        }
    }
}