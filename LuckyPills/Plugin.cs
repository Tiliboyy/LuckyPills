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

    /// <summary>
    /// The main plugin class.
    /// </summary>
    public class Plugin : Plugin<Config>
    {
        private EventHandlers eventHandlers;
        private PillManager pillManager;

        /// <inheritdoc />
        public override string Author { get; } = "Build";

        /// <inheritdoc />
        public override string Name { get; } = "LuckyPills";

        /// <inheritdoc />
        public override Version RequiredExiledVersion { get; } = new Version(3, 0, 0);

        /// <inheritdoc />
        public override Version Version { get; } = new Version(1, 0, 0);

        /// <inheritdoc />
        public override void OnEnabled()
        {
            RegisterEffects();
            pillManager = new PillManager();
            eventHandlers = new EventHandlers(pillManager);
            eventHandlers.Subscribe();
            base.OnEnabled();
        }

        /// <inheritdoc />
        public override void OnDisabled()
        {
            eventHandlers.Unsubscribe();
            eventHandlers = null;
            pillManager = null;
            UnregisterEffects();
            base.OnDisabled();
        }

        private void RegisterEffects()
        {
            Config.Amnesia?.Register();
            Config.Bleeding?.Register();
            Config.Blinded?.Register();
            Config.Concussed?.Register();
            Config.Corroding?.Register();
            Config.Ensnared?.Register();
            Config.Explode?.Register();
            Config.Flashed?.Register();
            Config.Flattened?.Register();
            Config.God?.Register();
            Config.GrenadeVomit?.Register();
            Config.Hemorrhage?.Register();
            Config.Invisible?.Register();
            Config.Mutate?.Register();
            Config.Paper?.Register();
            Config.Poisoned?.Register();
            Config.Sinkhole?.Register();
            Config.UpsideDown?.Register();
            Config.Visuals939?.Register();
        }

        private void UnregisterEffects()
        {
            Config.Amnesia?.Unregister();
            Config.Bleeding?.Unregister();
            Config.Blinded?.Unregister();
            Config.Concussed?.Unregister();
            Config.Corroding?.Unregister();
            Config.Ensnared?.Unregister();
            Config.Explode?.Unregister();
            Config.Flashed?.Unregister();
            Config.Flattened?.Unregister();
            Config.God?.Unregister();
            Config.GrenadeVomit?.Unregister();
            Config.Hemorrhage?.Unregister();
            Config.Invisible?.Unregister();
            Config.Mutate?.Unregister();
            Config.Paper?.Unregister();
            Config.Poisoned?.Unregister();
            Config.Sinkhole?.Unregister();
            Config.UpsideDown?.Unregister();
            Config.Visuals939?.Unregister();
        }
    }
}