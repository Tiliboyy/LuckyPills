// -----------------------------------------------------------------------
// <copyright file="EventHandlers.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace LuckyPills
{
    using Exiled.Events.EventArgs;

    /// <summary>
    /// Handles events derived from <see cref="Exiled.Events.Handlers"/>.
    /// </summary>
    public class EventHandlers
    {
        private readonly PillManager pillManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="EventHandlers"/> class.
        /// </summary>
        /// <param name="pillManager">An instance of the <see cref="PillManager"/> class.</param>
        public EventHandlers(PillManager pillManager)
        {
            this.pillManager = pillManager;
        }

        /// <summary>
        /// Subscribes to all required events.
        /// </summary>
        public void Subscribe()
        {
            Exiled.Events.Handlers.Player.UsingItem += OnUsingItem;
        }

        /// <summary>
        /// Unsubscribes from all required events.
        /// </summary>
        public void Unsubscribe()
        {
            Exiled.Events.Handlers.Player.UsingItem -= OnUsingItem;
        }

        /// <inheritdoc cref="Exiled.Events.Handlers.Player.OnUsingItem(UsingItemEventArgs)"/>
        private void OnUsingItem(UsingItemEventArgs ev)
        {
            if (ev.Item.Type == ItemType.Painkillers)
            {
                pillManager.RunEffect(ev.Player);
                ev.Player.RemoveHeldItem();
                ev.Player.CurrentItem = null;
            }
        }
    }
}