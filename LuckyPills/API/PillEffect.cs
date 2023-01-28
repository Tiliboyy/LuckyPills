// -----------------------------------------------------------------------
// <copyright file="PillEffect.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace LuckyPills.API
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Exiled.API.Features;
    using Exiled.Loader;
    using LuckyPills.Models;
    using MEC;

    /// <summary>
    /// Defines the contract for custom painkiller effects.
    /// </summary>
    public abstract class PillEffect : IEquatable<PillEffect>
    {
        /// <summary>
        /// Gets all registered <see cref="PillEffect"/>s.
        /// </summary>
        public static HashSet<PillEffect> Registered { get; } = new();

        /// <summary>
        /// Gets or sets the id of the effect.
        /// </summary>
        public abstract int Id { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the modifier can be used.
        /// </summary>
        public abstract bool IsEnabled { get; set; }

        /// <summary>
        /// Gets or sets the message to send to the player.
        /// </summary>
        public abstract string Translation { get; set; }

        /// <summary>
        /// Gets or sets the duration of the effect.
        /// </summary>
        public abstract Duration Duration { get; set; }

        /// <summary>
        /// Gets or sets the weight of this effect being chosen when <see cref="RunRandom"/> is executed.
        /// </summary>
        public abstract int Weight { get; set; }

        /// <summary>
        /// Gets a random enabled and registered <see cref="PillEffect"/>.
        /// </summary>
        /// <param name="player">The player to run the effect on.</param>
        public static void RunRandom(Player player)
        {
            var enabled = Registered.Where(effect => effect.IsEnabled).ToList();
            if (enabled.Count == 0)
            {
                Log.Warn("There are no enabled effects to select.");
                return;
            }

            var selectedEffect = enabled[Loader.Random.Next(enabled.Count)];
            int duration = selectedEffect.Duration?.Get() ?? 0;
            Log.Debug(selectedEffect.Translation);
            selectedEffect.OnEnabled(player, duration);
            player.ShowHint(selectedEffect.Translation.Replace("{duration}", duration.ToString()));
            Timing.CallDelayed(duration, () => selectedEffect.OnDisabled(player));
        }

        /// <summary>
        /// Registers an <see cref="IEnumerable{T}"/> of <see cref="PillEffect"/>s.
        /// </summary>
        /// <param name="effects">The effects to register.</param>
        /// <returns>The effects that were registered.</returns>
        public static IEnumerable<PillEffect> RegisterEffects(IEnumerable<PillEffect> effects) => effects.Where(effect => effect.Register());

        /// <summary>
        /// Unregisters all effects.
        /// </summary>
        public static void UnregisterEffects()
        {
            Registered.Clear();
        }

        /// <summary>
        /// Registers a <see cref="PillEffect"/>.
        /// </summary>
        /// <returns>Whether the effect was successfully registered.</returns>
        public bool Register()
        {
            if (Registered.Add(this))
                return true;

            PillEffect registeredEffect = Registered.First(effect => effect.Id == Id);
            Log.Error($"Failed to register {GetType().Name}: An effect with an identical ID ({registeredEffect.GetType().Name} | {Id}) already exists.");
            return false;
        }

        /// <summary>
        /// Unregisters all instances of a <see cref="PillEffect"/>.
        /// </summary>
        /// <returns>Whether the effect was unregistered.</returns>
        public bool Unregister() => Registered.Remove(this);

        /// <inheritdoc />
        public bool Equals(PillEffect other)
        {
            if (ReferenceEquals(null, other))
                return false;

            if (ReferenceEquals(this, other))
                return true;

            return Id == other.Id;
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;

            if (ReferenceEquals(this, obj))
                return true;

            return obj.GetType() == GetType() && Equals((PillEffect)obj);
        }

        /// <inheritdoc />
        public override int GetHashCode() => Id;

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