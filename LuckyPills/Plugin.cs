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
        private PossibleEffects possibleEffects;

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
            possibleEffects = new PossibleEffects(this);
            pillManager = new PillManager(possibleEffects);
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
            possibleEffects = null;
            base.OnDisabled();
        }
    }
}