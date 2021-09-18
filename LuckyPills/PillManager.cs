// -----------------------------------------------------------------------
// <copyright file="PillManager.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace LuckyPills
{
    using System;
    using System.Collections.Generic;
    using Exiled.API.Features;
    using LuckyPills.Interfaces;

    /// <summary>
    /// Handles the interactions between the player and the effect.
    /// </summary>
    public class PillManager
    {
        private readonly PossibleEffects possibleEffects;
        private readonly Random random;

        /// <summary>
        /// Initializes a new instance of the <see cref="PillManager"/> class.
        /// </summary>
        /// <param name="possibleEffects">An instance of the <see cref="PossibleEffects"/> class.</param>
        public PillManager(PossibleEffects possibleEffects)
        {
            this.possibleEffects = possibleEffects;
            random = Exiled.Loader.Loader.Random;
        }

        /// <summary>
        /// Runs a random effect for the given player.
        /// </summary>
        /// <param name="player">The player to run the effect for.</param>
        public void RunEffect(Player player)
        {
            KeyValuePair<IPillEffect, Action<Player, float>> effect = possibleEffects.GetRandomEffect();
            int duration = random.Next(effect.Key.MinimumDuration, effect.Key.MaximumDuration);
            effect.Value(player, duration);
            player.ShowHint(effect.Key.Translation.Replace("{duration}", duration.ToString()));
        }
    }
}