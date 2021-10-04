// -----------------------------------------------------------------------
// <copyright file="Config.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace LuckyPills
{
    using Exiled.API.Interfaces;
    using LuckyPills.Effects;
    using LuckyPills.Interfaces;

    /// <inheritdoc />
    public class Config : IConfig
    {
        /// <inheritdoc/>
        public bool IsEnabled { get; set; } = true;

        /// <summary>
        /// Gets or sets the configs for all usable effects.
        /// </summary>
        public IPillEffect[] Effects { get; set; } =
        {
            new Explode(),
            new Flattened(),
            new God(),
            new GrenadeVomit(),
            new Mutate(),
            new Paper(),
            new UpsideDown(),
        };
    }
}