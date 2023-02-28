// -----------------------------------------------------------------------
// <copyright file="UpsideDown.cs" company="Build">
// Copyright (c) Build. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

using System.Linq;
using PlayerRoles;

namespace LuckyPills.Effects
{
    using Exiled.API.Features;
    using LuckyPills.API;
    using LuckyPills.Models;
    using UnityEngine;

    /// <inheritdoc />
    public class Teleport : PillEffect
    {
        /// <inheritdoc />
        public override int Id { get; set; } = 26;

        /// <inheritdoc />
        public override bool IsEnabled { get; set; } = true;

        /// <inheritdoc />
        public override string Translation { get; set; } = "Du wurdest zu einem zufälligen SCP teleportiert!";

        /// <inheritdoc />
        public override Duration Duration { get; set; }

        /// <inheritdoc />
        public override int Weight { get; set; } = 1;

        /// <inheritdoc />
        protected override void OnEnabled(Player player, int duration)
        {
            var list = Player.List.Where(x => x.IsScp && x.Role.Type != RoleTypeId.Scp079).ToList();
            if (list.Count == 0)
            {
                player.ShowHint("Es konnte kein lebendes SCP gefunden werden.");
                return;
            }
            var scp = list[Random.Range(0, list.Count - 1)];
            player.Position = scp.Position;
        }
    }
}