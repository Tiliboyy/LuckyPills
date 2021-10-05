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

        public Explode Explode { get; set; } = new Explode();

        public Flattened Flattened { get; set; } = new Flattened();

        public God God { get; set; } = new God();

        public GrenadeVomit GrenadeVomit { get; set; } = new GrenadeVomit();

        public Mutate Mutate { get; set; } = new Mutate();

        public Paper Paper { get; set; } = new Paper();

        public UpsideDown UpsideDown { get; set; } = new UpsideDown();
    }
}