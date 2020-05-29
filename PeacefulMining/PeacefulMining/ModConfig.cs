﻿using System;
using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley;
using StardewValley.Locations;
using StardewValley.Menus;

namespace PeacefulMining
{
    /// <summary>The configuration file creation for the mod.</summary>
    internal class ModConfig
    {
        /*********
        ** Accessors
        *********/
        /// <summary>The default values.</summary>
        public static ModConfig Defaults { get; } = new ModConfig();

        /*********
        ** Toggleables
        *********/
        /// <summary>Whether to stop the monster's movement or disable them entirely.</summary>
        public bool StopMonsterMovement { get; set; } = true;

        ///<summary>Whether the mod should be active at all.</summary>
        public bool IsModActive { get; set; } = true;
    }
}
