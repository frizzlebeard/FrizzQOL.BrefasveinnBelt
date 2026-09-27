using System;

public static class BeltTeleport
{
    public const string PrefabName = "BrefasveinnBelt";

    public static bool AllowsTeleport(string equippedPrefabName, bool vanillaResult)
    {
        if (string.Equals(equippedPrefabName, PrefabName, StringComparison.Ordinal))
        {
            return true;
        }

        return vanillaResult;
    }
}
