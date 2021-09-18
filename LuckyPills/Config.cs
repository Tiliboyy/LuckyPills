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

    /// <inheritdoc />
    public class Config : IConfig
    {
        /// <inheritdoc/>
        public bool IsEnabled { get; set; } = true;

        /// <summary>
        /// Gets or sets the Explode effect configs.
        /// </summary>
        public Explode Explode { get; set; } = new Explode();

        /// <summary>
        /// Gets or sets the Flattened effect configs.
        /// </summary>
        public Flattened Flattened { get; set; } = new Flattened();

        /// <summary>
        /// Gets or sets the God effect configs.
        /// </summary>
        public God God { get; set; } = new God();

        /// <summary>
        /// Gets or sets the GrenadeVomit effect configs.
        /// </summary>
        public GrenadeVomit GrenadeVomit { get; set; } = new GrenadeVomit();

        /// <summary>
        /// Gets or sets the Mutate effect configs.
        /// </summary>
        public Mutate Mutate { get; set; } = new Mutate();

        /// <summary>
        /// Gets or sets the v effect configs.
        /// </summary>
        public Paper Paper { get; set; } = new Paper();

        /// <summary>
        /// Gets or sets the UpsideDown effect configs.
        /// </summary>
        public UpsideDown UpsideDown { get; set; } = new UpsideDown();
    }
}