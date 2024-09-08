using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using System.ComponentModel;
using UnityEngine;
using Exiled.Events.EventArgs;
using System.Collections.Generic;

namespace scp_294.Items.DrinkFeatures
{

    public class Scaling
    {
        private List<int> scaledPlayers = new List<int>();
        [Description("Whether or not the player should change appearance")]
        public bool ChangePlayerSize { get; set; } = false;
        /// <summary>
        /// Gets or sets the amount the player will be scaled on x-axis.
        /// </summary>
        [Description("How much the player should be scaled on x-axis")]
        public float x { get; set; } = 1;

        /// <summary>
        /// Gets or sets the amount the player will be scaled on y-axis.
        /// </summary>
        [Description("How much the player should be scaled on y-axis")]
        public float y { get; set; } = 1;

        /// <summary>
        /// Gets or sets the amount the player will be scaled on z-axis.
        /// </summary>
        [Description("How much the player should be scaled on z-axis")]
        public float z { get; set; } = 1;

        /// <summary>
        /// Applies the scale to the player.
        /// </summary>
        /// <param name="player">The <see cref="Player"/> instance.</param>
        public void ScalePlayer(Player player)
        {
            player.Scale = new Vector3(x, y, z);
            if (scaledPlayers.Count == 0)
            {
                Exiled.Events.Handlers.Player.Died += OnPlayerDied;
            }
            if (!scaledPlayers.Contains(player.Id))
            scaledPlayers.Add(player.Id);

        }

        private void OnPlayerDied(DiedEventArgs ev)
        {
            if (scaledPlayers.Contains(ev.Player.Id))
            {
                ev.Player.Scale= new Vector3(1, 1, 1);
                scaledPlayers.Remove(ev.Player.Id);
                if (scaledPlayers.Count == 0)
                {
                    Exiled.Events.Handlers.Player.Died -= OnPlayerDied;
                }
            }
        }
    }
}
