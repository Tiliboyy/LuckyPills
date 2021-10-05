// -----------------------------------------------------------------------
// <copyright file="PossibleEffects.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace LuckyPills
{
    using System.Linq;
    using LuckyPills.Interfaces;

    /// <summary>
    /// Handles the configured effects and their actions.
    /// </summary>
    public class PossibleEffects
    {
        private readonly IPillEffect[] effects;

        /// <summary>
        /// Initializes a new instance of the <see cref="PossibleEffects"/> class.
        /// </summary>
        /// <param name="plugin">An instance of the plugin class.</param>
        public PossibleEffects(Plugin plugin)
        {
            effects = new IPillEffect[]
            {
                plugin.Config.Amnesia,
                plugin.Config.Bleeding,
                plugin.Config.Blinded,
                plugin.Config.Concussed,
                plugin.Config.Corroding,
                plugin.Config.Ensnared,
                plugin.Config.Explode,
                plugin.Config.Flashed,
                plugin.Config.Flattened,
                plugin.Config.God,
                plugin.Config.GrenadeVomit,
                plugin.Config.Hemorrhage,
                plugin.Config.Invisible,
                plugin.Config.Mutate,
                plugin.Config.Paper,
                plugin.Config.Poisoned,
                plugin.Config.Sinkhole,
                plugin.Config.UpsideDown,
                plugin.Config.Visuals939,
            };
        }

        /// <summary>
        /// Gets a random effect from the configured effects.
        /// </summary>
        /// <returns>The configured effect and action.</returns>
        public IPillEffect GetRandomEffect()
        {
            return effects.Where(effect => effect.IsEnabled).ElementAt(Exiled.Loader.Loader.Random.Next(effects.Length));
        }
    }
}