using System.Collections.Generic;
using BepInEx;
using HarmonyLib;
using Jotunn;
using Jotunn.Entities;
using Jotunn.Managers;
using Jotunn.Utils;

namespace BrefasveinnBelt
{
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    [BepInDependency(Main.ModGuid)]
    [NetworkCompatibility(CompatibilityLevel.EveryoneMustHaveMod, VersionStrictness.Minor)]
    public class Plugin : BaseUnityPlugin
    {
        public const string PluginGuid = "com.frizzqol.brefasveinnbelt";
        public const string PluginName = "FrizzQOL Bréfasveinn Belt";
        public const string PluginVersion = "0.1.0";

        private Harmony _harmony;

        private void Awake()
        {
            AddLocalizations();
            BeltItem.Register();
            _harmony = new Harmony(PluginGuid);
            _harmony.PatchAll();
            Jotunn.Logger.LogInfo($"{PluginName} {PluginVersion} loaded");
        }

        private static void AddLocalizations()
        {
            CustomLocalization localization = LocalizationManager.Instance.GetLocalization();
            localization.AddTranslation("English", new Dictionary<string, string>
            {
                { "item_brefasveinnbelt", "Bréfasveinn Belt" },
                { "item_brefasveinnbelt_desc", "While worn, portals allow any items, including ores and metals." }
            });
        }
    }
}
