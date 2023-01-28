// -----------------------------------------------------------------------
// <copyright file="EffectsConfig.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace LuckyPills.Configs
{
    using System.Collections.Generic;
    using System.Reflection;
    using Exiled.API.Enums;
    using LuckyPills.API;
    using LuckyPills.Effects;

    /// <summary>
    /// All effect config settings.
    /// </summary>
    public class EffectsConfig
    {
        private readonly List<PillEffect> registeredEffects = new();
        

        /// <summary>
        /// Gets or sets all bleed effect configs.
        /// </summary>
        public List<Bleeding> Bleeding { get; set; } = new()
        {
            new Bleeding(),
        };

        /// <summary>
        /// Gets or sets all blindness effect configs.
        /// </summary>
        public List<Blinded> Blinded { get; set; } = new()
        {
            new Blinded(),
        };

        /// <summary>
        /// Gets or sets all concussion effect configs.
        /// </summary>
        public List<Concussed> Concussed { get; set; } = new()
        {
            new Concussed(),
        };

        /// <summary>
        /// Gets or sets all ensnare effect configs.
        /// </summary>
        public List<Ensnared> Ensnared { get; set; } = new()
        {
            new Ensnared(),
        };

        /// <summary>
        /// Gets or sets all explosion effect configs.
        /// </summary>
        public List<Explode> Explode { get; set; } = new()
        {
            new Explode(),
        };

        /// <summary>
        /// Gets or sets all flash effect configs.
        /// </summary>
        public List<Flashed> Flashed { get; set; } = new()
        {
            new Flashed(),
        };

        /// <summary>
        /// Gets or sets all flatten effect configs.
        /// </summary>
        public List<Flattened> Flattened { get; set; } = new()
        {
            new Flattened(),
        };

        /// <summary>
        /// Gets or sets all god effect configs.
        /// </summary>
        public List<God> God { get; set; } = new()
        {
            new God(),
        };

        /// <summary>
        /// Gets or sets all grenade vomit effect configs.
        /// </summary>
        public List<GrenadeVomit> GrenadeVomit { get; set; } = new()
        {
            new GrenadeVomit(ProjectileType.FragGrenade),
            new GrenadeVomit(ProjectileType.Flashbang) { Id = 12 },
            new GrenadeVomit(ProjectileType.Scp018) { Id = 13 },
        };

        /// <summary>
        /// Gets or sets all paper effect configs.
        /// </summary>
        public List<Paper> Paper { get; set; } = new()
        {
            new Paper(),
        };

        /// <summary>
        /// Gets or sets all poison effect configs.
        /// </summary>
        public List<Poisoned> Poisoned { get; set; } = new()
        {
            new Poisoned(),
        };

        /// <summary>
        /// Gets or sets all sinkhole effect configs.
        /// </summary>
        public List<Sinkhole> Sinkhole { get; set; } = new()
        {
            new Sinkhole(),
        };

        /// <summary>
        /// Gets or sets all upside down effect configs.
        /// </summary>
        public List<UpsideDown> UpsideDown { get; set; } = new()
        {
            new UpsideDown(),
        };
        /// <summary>
        /// Gets or sets all Morepills Effects
        /// </summary>
        public List<MorePills> MorePills { get; set; } = new()
        {
            new MorePills(),
        };

        /// <summary>
        /// Gets or sets all Scp939 visual effect configs.
        /// </summary>
        /// <summary>
        /// Registers all pill effects in this class.
        /// </summary>
        public void Register()
        {
            foreach (PropertyInfo property in GetType().GetProperties())
            {
                if (property.GetValue(this) is IEnumerable<PillEffect> effects)
                    registeredEffects.AddRange(PillEffect.RegisterEffects(effects));
            }
        }

        /// <summary>
        /// Unregisters all pill effects registered in this class.
        /// </summary>
        public void Unregister()
        {
            foreach (PillEffect pillEffect in registeredEffects)
                pillEffect.Unregister();

            registeredEffects.Clear();
        }
    }
}