// -----------------------------------------------------------------------
// <copyright file="EventHandlers.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

using Exiled.Events.EventArgs.Player;
using Exiled.Events.Handlers;
using LuckyPills.API;
using MEC;

namespace LuckyPills
{
    /// <summary>
    /// Handles events derived from <see cref="Exiled.Events.Handlers"/>.
    /// </summary>
    public class EventHandlers
    {
        private readonly Plugin plugin;

        /// <summary>
        /// Initializes a new instance of the <see cref="EventHandlers"/> class.
        /// </summary>
        /// <param name="plugin">An instance of the <see cref="Plugin"/> class.</param>
        public EventHandlers(Plugin plugin) => this.plugin = plugin;

        /// <inheritdoc cref="Exiled.Events.Handlers.Server.OnReloadedConfigs"/>
        public void OnReloadedConfigs() => plugin.Config.Reload();

        /// <summary>
        /// yes
        /// </summary>
        /// <param name="ev"></param>
        public void UsingItem(UsingItemEventArgs ev)
        {
            if(ev.Item.Type != ItemType.Painkillers) return;
            Timing.CallDelayed(0.4f, () =>
            {
                PillEffect.RunRandom(ev.Player);
                ev.Player.RemoveItem(ev.Item);
            });

        }
    }
}