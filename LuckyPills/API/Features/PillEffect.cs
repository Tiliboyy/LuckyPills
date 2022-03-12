// -----------------------------------------------------------------------
// <copyright file="PillEffect.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace LuckyPills.API.Features
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Exiled.API.Features;
    using MEC;

    /// <summary>
    /// Defines the contract for custom painkiller effects.
    /// </summary>
    public abstract class PillEffect
    {
        /// <inheritdoc cref="Exiled.Loader.Loader.Random"/>
        protected static readonly Random Random = Exiled.Loader.Loader.Random;

        /// <summary>
        /// Gets all registered <see cref="PillEffect"/>s.
        /// </summary>
        public static List<PillEffect> Registered { get; } = new List<PillEffect>();

        /// <summary>
        /// Gets or sets a value indicating whether the modifier can be used.
        /// </summary>
        public abstract bool IsEnabled { get; set; }

        /// <summary>
        /// Gets or sets the message to send to the player.
        /// </summary>
        public abstract string Translation { get; set; }

        /// <summary>
        /// Gets or sets the minimum duration of the effect.
        /// </summary>
        public abstract int MinimumDuration { get; set; }

        /// <summary>
        /// Gets or sets the maximum duration of the effect.
        /// </summary>
        public abstract int MaximumDuration { get; set; }

        /// <summary>
        /// Gets or sets the amount of times this effect should be registered.
        /// </summary>
        public abstract int Odds { get; set; }

        /// <summary>
        /// Gets a random enabled and registered <see cref="PillEffect"/>.
        /// </summary>
        /// <param name="player">The player to run the effect on.</param>
        public static void RunRandom(Player player)
        {
            List<PillEffect> enabled = Registered.Where(effect => effect.IsEnabled).ToList();
            if (enabled.Count == 0)
            {
                Log.Warn("There are no enabled effects to select.");
                return;
            }

            PillEffect selectedEffect = enabled[Random.Next(enabled.Count)];
            int duration = Random.Next(selectedEffect.MinimumDuration, selectedEffect.MaximumDuration);
            selectedEffect.OnEnabled(player, duration);
            player.ShowHint(selectedEffect.Translation.Replace("{duration}", duration.ToString()));
            Timing.CallDelayed(duration, () => selectedEffect.OnDisabled(player));
        }

        /// <summary>
        /// Registers a <see cref="PillEffect"/>.
        /// </summary>
        public void Register()
        {
            for (int i = 0; i < Odds; i++)
                Registered.Add(this);
        }

        /// <summary>
        /// Unregisters all instances of a <see cref="PillEffect"/>.
        /// </summary>
        public void Unregister()
        {
            Registered.RemoveAll(effect => effect == this);
        }

        /// <summary>
        /// Runs the effect on the player who consumes the pills.
        /// </summary>
        /// <param name="player">The player to be affected.</param>
        /// <param name="duration">The amount of time, in seconds, that the effect should last.</param>
        protected abstract void OnEnabled(Player player, int duration);

        /// <summary>
        /// Disables the effect on the player who consumed the pills.
        /// </summary>
        /// <param name="player">The player to be affected.</param>
        protected virtual void OnDisabled(Player player)
        {
        }
    }
}