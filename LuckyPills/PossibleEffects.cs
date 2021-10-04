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
        private readonly System.Random random;

        /// <summary>
        /// Initializes a new instance of the <see cref="PossibleEffects"/> class.
        /// </summary>
        /// <param name="plugin">An instance of the plugin class.</param>
        public PossibleEffects(Plugin plugin)
        {
            effects = plugin.Config.Effects;
            random = Exiled.Loader.Loader.Random;
        }

        /// <summary>
        /// Gets a random effect from the configured effects.
        /// </summary>
        /// <returns>The configured effect and action.</returns>
        public IPillEffect GetRandomEffect()
        {
            return effects.Where(kvp => kvp.IsEnabled).ElementAt(random.Next(effects.Length));
        }
    }
}