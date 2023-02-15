// -----------------------------------------------------------------------
// <copyright file="Sinkhole.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------


using CustomPlayerEffects;
using PluginAPI.Core.Zones.Pocket;

namespace LuckyPills.Effects
{
    using Exiled.API.Features;
    using API;
    using Models;
    
    /// <inheritdoc />
    public class Sinkhole : PillEffect
    {
        /// <inheritdoc />
        public override int Id { get; set; } = 19;

        /// <inheritdoc />
        public override bool IsEnabled { get; set; } = true;

        /// <inheritdoc />
        public override string Translation { get; set; } = "Du wurdest in die Pocket Dimension geschickt!";

        /// <inheritdoc />
        public override Duration Duration { get; set; } = new(10, 20);

        /// <inheritdoc />
        public override int Weight { get; set; } = 1;

        /// <inheritdoc />
        protected override void OnEnabled(Player player, int duration)
        {
            player.IsGodModeEnabled = false;   
            player.EnableEffect<Traumatized>(180f);
            player.EnableEffect<Corroding>(0, false);
        }

        /// <inheritdoc />
        protected override void OnDisabled(Player player)
        {
            
        }
    }
}