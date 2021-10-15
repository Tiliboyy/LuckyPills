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
        /// Gets or sets the configs for the amnesia pill effect.
        /// </summary>
        public Amnesia Amnesia { get; set; } = new Amnesia();

        /// <summary>
        /// Gets or sets the configs for the bleeding pill effect.
        /// </summary>
        public Bleeding Bleeding { get; set; } = new Bleeding();

        /// <summary>
        /// Gets or sets the configs for the blinded pill effect.
        /// </summary>
        public Blinded Blinded { get; set; } = new Blinded();

        /// <summary>
        /// Gets or sets the configs for the concussed pill effect.
        /// </summary>
        public Concussed Concussed { get; set; } = new Concussed();

        /// <summary>
        /// Gets or sets the configs for the corroding pill effect.
        /// </summary>
        public Corroding Corroding { get; set; } = new Corroding();

        /// <summary>
        /// Gets or sets the configs for the ensnared pill effect.
        /// </summary>
        public Ensnared Ensnared { get; set; } = new Ensnared();

        /// <summary>
        /// Gets or sets the configs for the explode pill effect.
        /// </summary>
        public Explode Explode { get; set; } = new Explode();

        /// <summary>
        /// Gets or sets the configs for the flashed pill effect.
        /// </summary>
        public Flashed Flashed { get; set; } = new Flashed();

        /// <summary>
        /// Gets or sets the configs for the flattened pill effect.
        /// </summary>
        public Flattened Flattened { get; set; } = new Flattened();

        /// <summary>
        /// Gets or sets the configs for the god pill effect.
        /// </summary>
        public God God { get; set; } = new God();

        /// <summary>
        /// Gets or sets the configs for the grenade vomit pill effect.
        /// </summary>
        public GrenadeVomit GrenadeVomit { get; set; } = new GrenadeVomit();

        /// <summary>
        /// Gets or sets the configs for the hemorrhage pill effect.
        /// </summary>
        public Hemorrhage Hemorrhage { get; set; } = new Hemorrhage();

        /// <summary>
        /// Gets or sets the configs for the invisibility pill effect.
        /// </summary>
        public Invisible Invisible { get; set; } = new Invisible();

        /// <summary>
        /// Gets or sets the configs for the mutate pill effect.
        /// </summary>
        public Mutate Mutate { get; set; } = new Mutate();

        /// <summary>
        /// Gets or sets the configs for the paper pill effect.
        /// </summary>
        public Paper Paper { get; set; } = new Paper();

        /// <summary>
        /// Gets or sets the configs for the poisoned pill effect.
        /// </summary>
        public Poisoned Poisoned { get; set; } = new Poisoned();

        /// <summary>
        /// Gets or sets the configs for the sinkhole pill effect.
        /// </summary>
        public Sinkhole Sinkhole { get; set; } = new Sinkhole();

        /// <summary>
        /// Gets or sets the configs for the upside down pill effect.
        /// </summary>
        public UpsideDown UpsideDown { get; set; } = new UpsideDown();

        /// <summary>
        /// Gets or sets the configs for the Scp939 visuals pill effect.
        /// </summary>
        public Visuals939 Visuals939 { get; set; } = new Visuals939();
    }
}