// -----------------------------------------------------------------------
// <copyright file="Extensions.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace LuckyPills.API
{
    using System;
    using System.Collections.Generic;
    using LuckyPills.API;

    /// <summary>
    /// Various extensions for <see cref="IEnumerable{T}"/>.
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Registers an <see cref="IEnumerable{T}"/> of <see cref="PillEffect"/>s.
        /// </summary>
        /// <param name="effects">The effects to register.</param>
        public static void Register(this IEnumerable<PillEffect> effects)
        {
            if (effects == null)
                throw new ArgumentNullException(nameof(effects));

            foreach (PillEffect effect in effects)
                effect.Register();
        }

        /// <summary>
        /// Unregisters an <see cref="IEnumerable{T}"/> of <see cref="PillEffect"/>s.
        /// </summary>
        /// <param name="effects">The effects to unregister.</param>
        public static void Unregister(this IEnumerable<PillEffect> effects)
        {
            if (effects == null)
                throw new ArgumentNullException(nameof(effects));

            foreach (PillEffect effect in effects)
                effect.Unregister();
        }
    }
}