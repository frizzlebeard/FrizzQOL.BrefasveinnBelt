using Xunit;

public class BeltTeleportTests
{
    [Fact]
    public void Equipped_belt_allows_teleport_when_vanilla_blocks()
    {
        Assert.True(BeltTeleport.AllowsTeleport(BeltTeleport.PrefabName, false));
    }

    [Fact]
    public void Other_utility_item_keeps_vanilla_block()
    {
        Assert.False(BeltTeleport.AllowsTeleport("BeltStrength", false));
    }

    [Fact]
    public void Other_utility_item_keeps_vanilla_allow()
    {
        Assert.True(BeltTeleport.AllowsTeleport("BeltStrength", true));
    }

    [Fact]
    public void Null_or_empty_equip_keeps_vanilla_result()
    {
        Assert.False(BeltTeleport.AllowsTeleport(null!, false));
        Assert.True(BeltTeleport.AllowsTeleport("", true));
    }

    [Fact]
    public void Prefab_name_is_ascii_BrefasveinnBelt()
    {
        Assert.Equal("BrefasveinnBelt", BeltTeleport.PrefabName);
    }
}
