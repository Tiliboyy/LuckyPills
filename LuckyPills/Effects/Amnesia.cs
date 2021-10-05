// -----------------------------------------------------------------------
// <copyright file="Amnesia.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace LuckyPills.Effects
{
    using Exiled.API.Features;
    using LuckyPills.Interfaces;

    public class Amnesia : IPillEffect
    {
        /// <inheritdoc />
        public bool IsEnabled { get; set; }

        /// <inheritdoc />
        public string Translation { get; set; }

        /// <inheritdoc />
        public int MinimumDuration { get; set; }

        /// <inheritdoc />
        public int MaximumDuration { get; set; }

        /// <inheritdoc />
        public void RunEffect(Player player, int duration)
        {
            player.EnableEffect<CustomPlayerEffects.Amnesia>(duration);
        }
    }
}