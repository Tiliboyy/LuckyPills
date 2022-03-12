// -----------------------------------------------------------------------
// <copyright file="EventHandlers.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace LuckyPills
{
    using Exiled.Events.EventArgs;
    using LuckyPills.API.Features;

    /// <summary>
    /// Handles events derived from <see cref="Exiled.Events.Handlers"/>.
    /// </summary>
    public class EventHandlers
    {
        /// <inheritdoc cref="Exiled.Events.Handlers.Player.OnUsingItem(UsingItemEventArgs)"/>
        public void OnUsingItem(UsingItemEventArgs ev)
        {
            if (ev.Item.Type == ItemType.Painkillers)
            {
                PillEffect.RunRandom(ev.Player);
                ev.Player.RemoveHeldItem();
            }
        }
    }
}