// -----------------------------------------------------------------------
// <copyright file="IPillEffect.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace LuckyPills.Interfaces
{
    /// <summary>
    /// Defines the contract for custom painkiller effects.
    /// </summary>
    public interface IPillEffect
    {
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
    }
}