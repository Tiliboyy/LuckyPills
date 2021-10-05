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

        public Amnesia Amnesia { get; set; } = new Amnesia();

        public Bleeding Bleeding { get; set; } = new Bleeding();

        public Blinded Blinded { get; set; } = new Blinded();

        public Concussed Concussed { get; set; } = new Concussed();

        public Corroding Corroding { get; set; } = new Corroding();

        public Ensnared Ensnared { get; set; } = new Ensnared();

        public Explode Explode { get; set; } = new Explode();

        public Flashed Flashed { get; set; } = new Flashed();

        public Flattened Flattened { get; set; } = new Flattened();

        public God God { get; set; } = new God();

        public GrenadeVomit GrenadeVomit { get; set; } = new GrenadeVomit();

        public Hemorrhage Hemorrhage { get; set; } = new Hemorrhage();

        public Invisible Invisible { get; set; } = new Invisible();

        public Mutate Mutate { get; set; } = new Mutate();

        public Paper Paper { get; set; } = new Paper();

        public Poisoned Poisoned { get; set; } = new Poisoned();

        public Sinkhole Sinkhole { get; set; } = new Sinkhole();

        public UpsideDown UpsideDown { get; set; } = new UpsideDown();

        public Visuals939 Visuals939 { get; set; } = new Visuals939();
    }
}