using Harmony12;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using UnityModManagerNet;

namespace TestMod
{
    public class Main
    {
        public static bool Enable { get; set; }

        // Transfer a variable with data about the mod.
        static void Load(UnityModManager.ModEntry modEntry)
        {
            // modEntry.Info - Contains all fields from the 'Info.json' file.
            // modEntry.Path - The path to the mod folder e.g. '\Steam\steamapps\common\YourGame\Mods\TestMod\'.
            // modEntry.Active - Active or inactive.
            // modEntry.Logger - Writes logs to the 'UnityModManager.log' file.
            // modEntry.OnToggle - The presence of this function will let the mod manager know that the mod can be safely disabled during the game.
            // modEntry.OnGUI - Drawing mod options.
            // modEntry.OnSaveGUI - Called while saving.
            HarmonyInstance.Create(modEntry.Info.Id).PatchAll(Assembly.GetExecutingAssembly());

        }
    }
}
