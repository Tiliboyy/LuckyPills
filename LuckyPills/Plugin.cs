// -----------------------------------------------------------------------
// <copyright file="Plugin.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace LuckyPills
{
    using System;
    using Exiled.API.Features;
    using LuckyPills.API;

    /// <summary>
    /// The main plugin class.
    /// </summary>
    public class Plugin : Plugin<Config>
    {
        private EventHandlers eventHandlers;

        /// <inheritdoc />
        public override string Author => "Build";

        /// <inheritdoc />
        public override string Name => "LuckyPills";

        /// <inheritdoc />
        public override string Prefix => "LuckyPills";

        /// <inheritdoc />
        public override Version RequiredExiledVersion { get; } = new Version(5, 0, 0);

        /// <inheritdoc />
        public override Version Version { get; } = new Version(2, 0, 0);

        /// <inheritdoc />
        public override void OnEnabled()
        {
            eventHandlers = new EventHandlers();
            Exiled.Events.Handlers.Player.UsingItem += eventHandlers.OnUsingItem;

            Config.LoadEffects();
            RegisterEffects();

            base.OnEnabled();
        }

        /// <inheritdoc />
        public override void OnDisabled()
        {
            UnregisterEffects();

            Exiled.Events.Handlers.Player.UsingItem -= eventHandlers.OnUsingItem;
            eventHandlers = null;

            base.OnDisabled();
        }

        private void RegisterEffects()
        {
            Config.EffectConfigs.Amnesia?.Register();
            Config.EffectConfigs.Bleeding?.Register();
            Config.EffectConfigs.Blinded?.Register();
            Config.EffectConfigs.Concussed?.Register();
            Config.EffectConfigs.Corroding?.Register();
            Config.EffectConfigs.Ensnared?.Register();
            Config.EffectConfigs.Explode?.Register();
            Config.EffectConfigs.Flashed?.Register();
            Config.EffectConfigs.Flattened?.Register();
            Config.EffectConfigs.God?.Register();
            Config.EffectConfigs.GrenadeVomit?.Register();
            Config.EffectConfigs.Hemorrhage?.Register();
            Config.EffectConfigs.Invisible?.Register();
            Config.EffectConfigs.Mutate?.Register();
            Config.EffectConfigs.Paper?.Register();
            Config.EffectConfigs.Poisoned?.Register();
            Config.EffectConfigs.Sinkhole?.Register();
            Config.EffectConfigs.UpsideDown?.Register();
            Config.EffectConfigs.Visuals939?.Register();
        }

        private void UnregisterEffects()
        {
            Config.EffectConfigs.Amnesia?.Unregister();
            Config.EffectConfigs.Bleeding?.Unregister();
            Config.EffectConfigs.Blinded?.Unregister();
            Config.EffectConfigs.Concussed?.Unregister();
            Config.EffectConfigs.Corroding?.Unregister();
            Config.EffectConfigs.Ensnared?.Unregister();
            Config.EffectConfigs.Explode?.Unregister();
            Config.EffectConfigs.Flashed?.Unregister();
            Config.EffectConfigs.Flattened?.Unregister();
            Config.EffectConfigs.God?.Unregister();
            Config.EffectConfigs.GrenadeVomit?.Unregister();
            Config.EffectConfigs.Hemorrhage?.Unregister();
            Config.EffectConfigs.Invisible?.Unregister();
            Config.EffectConfigs.Mutate?.Unregister();
            Config.EffectConfigs.Paper?.Unregister();
            Config.EffectConfigs.Poisoned?.Unregister();
            Config.EffectConfigs.Sinkhole?.Unregister();
            Config.EffectConfigs.UpsideDown?.Unregister();
            Config.EffectConfigs.Visuals939?.Unregister();
        }
    }
}