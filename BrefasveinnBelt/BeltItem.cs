using Jotunn.Configs;
using Jotunn.Entities;
using Jotunn.Managers;

namespace BrefasveinnBelt
{
    internal static class BeltItem
    {
        public static void Register()
        {
            PrefabManager.OnVanillaPrefabsAvailable += AddClonedBelt;
        }

        private static void AddClonedBelt()
        {
            try
            {
                if (PrefabManager.Instance.GetPrefab("BeltStrength") == null)
                {
                    Jotunn.Logger.LogError("BeltStrength prefab missing. Bréfasveinn Belt was not registered.");
                    return;
                }

                ItemConfig config = new ItemConfig();
                config.Name = "$item_brefasveinnbelt";
                config.Description = "$item_brefasveinnbelt_desc";
                config.CraftingStation = CraftingStations.Forge;
                config.AddRequirement("Iron", 10);
                config.AddRequirement("DeerHide", 5);
                config.AddRequirement("Silver", 3);
                config.AddRequirement("SurtlingCore", 1);

                CustomItem belt = new CustomItem(BeltTeleport.PrefabName, "BeltStrength", config);
                if (belt.ItemDrop != null)
                {
                    belt.ItemDrop.m_itemData.m_shared.m_equipStatusEffect = null;
                }

                ItemManager.Instance.AddItem(belt);
                Jotunn.Logger.LogInfo("Registered Bréfasveinn Belt");
            }
            finally
            {
                PrefabManager.OnVanillaPrefabsAvailable -= AddClonedBelt;
            }
        }
    }
}
