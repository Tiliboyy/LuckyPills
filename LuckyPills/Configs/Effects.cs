// -----------------------------------------------------------------------
// <copyright file="Effects.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace LuckyPills.Configs
{
    using System.Collections.Generic;
    using Exiled.API.Enums;
    using LuckyPills.Effects;

    /// <summary>
    /// All effect config settings.
    /// </summary>
    public class Effects
    {
        /// <summary>
        /// Gets or sets all amnesia effect configs.
        /// </summary>
        public List<Amnesia> Amnesia { get; set; } = new List<Amnesia>
        {
            new Amnesia(),
        };

        /// <summary>
        /// Gets or sets all bleed effect configs.
        /// </summary>
        public List<Bleeding> Bleeding { get; set; } = new List<Bleeding>
        {
            new Bleeding(),
        };

        /// <summary>
        /// Gets or sets all blindness effect configs.
        /// </summary>
        public List<Blinded> Blinded { get; set; } = new List<Blinded>
        {
            new Blinded(),
        };

        /// <summary>
        /// Gets or sets all concussion effect configs.
        /// </summary>
        public List<Concussed> Concussed { get; set; } = new List<Concussed>
        {
            new Concussed(),
        };

        /// <summary>
        /// Gets or sets all corrosion effect configs.
        /// </summary>
        public List<Corroding> Corroding { get; set; } = new List<Corroding>
        {
            new Corroding(),
        };

        /// <summary>
        /// Gets or sets all ensnare effect configs.
        /// </summary>
        public List<Ensnared> Ensnared { get; set; } = new List<Ensnared>
        {
            new Ensnared(),
        };

        /// <summary>
        /// Gets or sets all explosion effect configs.
        /// </summary>
        public List<Explode> Explode { get; set; } = new List<Explode>
        {
            new Explode(),
        };

        /// <summary>
        /// Gets or sets all flash effect configs.
        /// </summary>
        public List<Flashed> Flashed { get; set; } = new List<Flashed>
        {
            new Flashed(),
        };

        /// <summary>
        /// Gets or sets all flatten effect configs.
        /// </summary>
        public List<Flattened> Flattened { get; set; } = new List<Flattened>
        {
            new Flattened(),
        };

        /// <summary>
        /// Gets or sets all god effect configs.
        /// </summary>
        public List<God> God { get; set; } = new List<God>
        {
            new God(),
        };

        /// <summary>
        /// Gets or sets all grenade vomit effect configs.
        /// </summary>
        public List<GrenadeVomit> GrenadeVomit { get; set; } = new List<GrenadeVomit>
        {
            new GrenadeVomit { GrenadeType = GrenadeType.FragGrenade },
            new GrenadeVomit { GrenadeType = GrenadeType.Flashbang },
            new GrenadeVomit { GrenadeType = GrenadeType.Scp018 },
        };

        /// <summary>
        /// Gets or sets all hemorrhage effect configs.
        /// </summary>
        public List<Hemorrhage> Hemorrhage { get; set; } = new List<Hemorrhage>
        {
            new Hemorrhage(),
        };

        /// <summary>
        /// Gets or sets all invisibility effect configs.
        /// </summary>
        public List<Invisible> Invisible { get; set; } = new List<Invisible>
        {
            new Invisible(),
        };

        /// <summary>
        /// Gets or sets all mutation effect configs.
        /// </summary>
        public List<Mutate> Mutate { get; set; } = new List<Mutate>
        {
            new Mutate(),
        };

        /// <summary>
        /// Gets or sets all paper effect configs.
        /// </summary>
        public List<Paper> Paper { get; set; } = new List<Paper>
        {
            new Paper(),
        };

        /// <summary>
        /// Gets or sets all poison effect configs.
        /// </summary>
        public List<Poisoned> Poisoned { get; set; } = new List<Poisoned>
        {
            new Poisoned(),
        };

        /// <summary>
        /// Gets or sets all sinkhole effect configs.
        /// </summary>
        public List<Sinkhole> Sinkhole { get; set; } = new List<Sinkhole>
        {
            new Sinkhole(),
        };

        /// <summary>
        /// Gets or sets all upside down effect configs.
        /// </summary>
        public List<UpsideDown> UpsideDown { get; set; } = new List<UpsideDown>
        {
            new UpsideDown(),
        };

        /// <summary>
        /// Gets or sets all Scp939 visual effect configs.
        /// </summary>
        public List<Visuals939> Visuals939 { get; set; } = new List<Visuals939>
        {
            new Visuals939(),
        };
    }
}