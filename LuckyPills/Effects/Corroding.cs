// -----------------------------------------------------------------------
// <copyright file="Corroding.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace LuckyPills.Effects
{
    using Exiled.API.Features;
    using LuckyPills.API.Features;
    using YamlDotNet.Serialization;

    /// <inheritdoc />
    public class Corroding : PillEffect
    {
        /// <inheritdoc />
        public override bool IsEnabled { get; set; } = true;

        /// <inheritdoc />
        public override string Translation { get; set; } = "You've been sent to the pocket dimension";

        /// <inheritdoc />
        [YamlIgnore]
        public override int MinimumDuration { get; set; }

        /// <inheritdoc />
        [YamlIgnore]
        public override int MaximumDuration { get; set; }

        /// <inheritdoc />
        public override int Odds { get; set; } = 1;

        /// <inheritdoc />
        public override void RunEffect(Player player, int duration)
        {
            player.ReferenceHub.scp106PlayerScript.GrabbedPosition = player.Position;
            player.EnableEffect<CustomPlayerEffects.Corroding>();
        }
    }
}