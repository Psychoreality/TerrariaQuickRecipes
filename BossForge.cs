using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MechParadise
{
    public class BossForge : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ultimate Loot Reconstructor");
            Tooltip.SetDefault("'The power to mold the loot of a boss monster is in your hands'");
            Tooltip.SetDefault("Deconstruct boss loot and invasion drops here");
            }
            
        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 26;
            item.maxStack = 999;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("BossForge");
            item.value = 1000;
            item.rare = 1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Furnace, 1);
            recipe.AddIngredient(ItemID.GoldBar, 20);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
    