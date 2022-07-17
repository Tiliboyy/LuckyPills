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
    using HarmonyLib;

    /// <summary>
    /// The main plugin class.
    /// </summary>
    public class Plugin : Plugin<Config>
    {
        private EventHandlers eventHandlers;
        private Harmony harmony;

        /// <inheritdoc />
        public override string Author => "Build";

        /// <inheritdoc />
        public override string Name => "LuckyPills";

        /// <inheritdoc />
        public override string Prefix => "LuckyPills";

        /// <inheritdoc />
        public override Version RequiredExiledVersion { get; } = new(5, 3, 0);

        /// <inheritdoc />
        public override Version Version { get; } = new(3, 0, 0);

        /// <inheritdoc />
        public override void OnEnabled()
        {
            Config.Reload();
            Config.Effects.Register();

            harmony = new Harmony($"luckyPills.{DateTime.UtcNow.Ticks}");
            harmony.PatchAll();

            eventHandlers = new EventHandlers(this);
            Exiled.Events.Handlers.Server.ReloadedConfigs += eventHandlers.OnReloadedConfigs;

            base.OnEnabled();
        }

        /// <inheritdoc />
        public override void OnDisabled()
        {
            Config.Effects.Unregister();

            Exiled.Events.Handlers.Server.ReloadedConfigs -= eventHandlers.OnReloadedConfigs;
            eventHandlers = null;

            harmony.UnpatchAll(harmony.Id);
            harmony = null;

            base.OnDisabled();
        }
    }
}