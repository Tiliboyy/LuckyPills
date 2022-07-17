// -----------------------------------------------------------------------
// <copyright file="Duration.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace LuckyPills.Models
{
    using System;
    using Exiled.Loader;

    /// <summary>
    /// Represents a duration with configurable minimum and maximum values.
    /// </summary>
    [Serializable]
    public class Duration
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Duration"/> class.
        /// </summary>
        public Duration()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Duration"/> class.
        /// </summary>
        /// <param name="minimum"><inheritdoc cref="Minimum"/></param>
        /// <param name="maximum"><inheritdoc cref="Maximum"/></param>
        public Duration(int minimum, int maximum)
        {
            Minimum = minimum;
            Maximum = maximum;
        }

        /// <summary>
        /// Gets or sets the minimum duration.
        /// </summary>
        public int Minimum { get; set; }

        /// <summary>
        /// Gets or sets the maximum duration.
        /// </summary>
        public int Maximum { get; set; }

        /// <summary>
        /// Returns a random duration between the <see cref="Minimum"/> and <see cref="Maximum"/> values.
        /// </summary>
        /// <returns>A value between the <see cref="Minimum"/> and <see cref="Maximum"/> values.</returns>
        public int Get() => Loader.Random.Next(Minimum, Maximum);
    }
}