using HarmonyLib;
using UnityEngine;

namespace BrefasveinnBelt
{
    [HarmonyPatch(typeof(Humanoid), nameof(Humanoid.IsTeleportable))]
    internal static class TeleportPatch
    {
        private static void Postfix(Humanoid __instance, ref bool __result)
        {
            Player player = __instance as Player;
            if (player == null || player.m_utilityItem?.m_dropPrefab == null)
            {
                return;
            }

            string prefabName = Utils.GetPrefabName(player.m_utilityItem.m_dropPrefab);
            __result = BeltTeleport.AllowsTeleport(prefabName, __result);
        }
    }
}
