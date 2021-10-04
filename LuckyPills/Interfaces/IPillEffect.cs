// -----------------------------------------------------------------------
// <copyright file="IPillEffect.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace LuckyPills.Interfaces
{
    using Exiled.API.Features;

    /// <summary>
    /// Defines the contract for custom painkiller effects.
    /// </summary>
    public interface IPillEffect
    {
        /// <summary>
        /// Gets or sets a value indicating whether the modifier can be used.
        /// </summary>
        bool IsEnabled { get; set; }

        /// <summary>
        /// Gets or sets the message to send to the player.
        /// </summary>
        string Translation { get; set; }

        /// <summary>
        /// Gets or sets the minimum duration of the effect.
        /// </summary>
        int MinimumDuration { get; set; }

        /// <summary>
        /// Gets or sets the maximum duration of the effect.
        /// </summary>
        int MaximumDuration { get; set; }

        /// <summary>
        /// Runs the effect on the player who consumes the pills.
        /// </summary>
        /// <param name="player">The player to be affected.</param>
        /// <param name="duration">The amount of time, in seconds, that the effect should last.</param>
        void RunEffect(Player player, int duration);
    }
}