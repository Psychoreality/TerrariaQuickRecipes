using System;
using Terraria;
using Terraria.ID;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ModLoader;

public static class TrapRecipes
{
    public static void Trap Recipes (Mod this)
    {
        

        ModRecipe recipe;

        recipe = new ModRecipe (this);
        recipe.AddIngredient(Terraria.ID.ItemID.StoneBlock, 30);
        recipe.AddIngredient(Terraria.ID.ItemID.Wire, 1);
        recipe.AddIngredient(Terraria.ID.ItemID.ThrowingKnife, 50);
        recipe.AddTile(Terraria.ID.TileID.TinkerersWorkshop);
        recipe.SetResult(Terraria.ID.ItemID.DartTrap, 1);
        recipe.AddRecipe();

        recipe = new ModRecipe (this);
        recipe.AddIngredient(Terraria.ID.ItemID.CopperBar, 5);
        recipe.AddIngredient(Terraria.ID.ItemID.Gel, 50);
        recipe.AddTile(Terraria.ID.TileID.TinkerersWorkshop);
        recipe.SetResult(Terraria.ID.ItemID.Wire, 10);
        recipe.AddRecipe();

        recipe = new ModRecipe (this);
        recipe.AddIngredient(Terraria.ID.ItemID.TinBar, 5);
        recipe.AddIngredient(Terraria.ID.ItemID.Gel, 50);
        recipe.AddTile(Terraria.ID.TileID.TinkerersWorkshop);
        recipe.SetResult(Terraria.ID.ItemID.Wire, 10);
        recipe.AddRecipe();

        recipe = new ModRecipe (this);
        recipe.AddIngredient(Terraria.ID.ItemID.DartTrap, 1);
        recipe.AddIngredient(Terraria.ID.ItemID.LizahrdBrick, 20);
        recipe.AddIngredient(Terraria.ID.ItemID.VialOfVenom, 1);
        recipe.AddTile(Terraria.ID.TileID.TinkerersWorkshop);
        recipe.SetResult(Terraria.ID.ItemID.SuperDartTrap, 1);
        recipe.AddRecipe();

        recipe = new ModRecipe (this);
        recipe.AddIngredient(Terraria.ID.ItemID.DartTrap, 1);
        recipe.AddIngredient(Terraria.ID.ItemID.LizahrdBrick, 20);
        recipe.AddIngredient(Terraria.ID.ItemID.Gel, 200);
        recipe.AddTile(Terraria.ID.TileID.TinkerersWorkshop);
        recipe.SetResult(Terraria.ID.ItemID.FlameTrap, 1);
        recipe.AddRecipe();

        recipe = new ModRecipe (this);
        recipe.AddIngredient(Terraria.ID.ItemID.Wire, 1);
        recipe.AddIngredient(Terraria.ID.ItemID.LizahrdBrick, 30);
        recipe.AddIngredient(Terraria.ID.ItemID.SpikyBall, 200);
        recipe.AddTile(Terraria.ID.TileID.TinkerersWorkshop);
        recipe.SetResult(Terraria.ID.ItemID.SpikyBallTrap, 1);
        recipe.AddRecipe();

        recipe = new ModRecipe (this);
        recipe.AddIngredient(Terraria.ID.ItemID.Wire, 1);
        recipe.AddIngredient(Terraria.ID.ItemID.LizahrdBrick, 30);
        recipe.AddIngredient(Terraria.ID.ItemID.Spike, 1);
        recipe.AddIngredient(Terraria.ID.ItemID.IronBar, 5);
        recipe.AddTile(Terraria.ID.TileID.TinkerersWorkshop);
        recipe.SetResult(Terraria.ID.ItemID.SpearTrap, 1);
        recipe.AddRecipe();

        recipe = new ModRecipe (this);
        recipe.AddIngredient(Terraria.ID.ItemID.Wire, 1);
        recipe.AddIngredient(Terraria.ID.ItemID.LizahrdBrick, 30);
        recipe.AddIngredient(Terraria.ID.ItemID.Spike, 1);
        recipe.AddIngredient(Terraria.ID.ItemID.LeadBar, 5);
        recipe.AddTile(Terraria.ID.TileID.TinkerersWorkshop);
        recipe.SetResult(Terraria.ID.ItemID.SpearTrap, 1);
        recipe.AddRecipe();
        }
    


public static void EquipRecipes (Mod this)
{
    ModRecipe recipe;
    
    recipe = new ModRecipe (this);
    recipe.AddIngredient(Terraria.ID.ItemID.BandOfRegeneration, 1);
    recipe.AddIngredient(Terraria.ID.ItemID.ManaCrystal, 1);
    recipe.AddTile(Terraria.ID.ItemID.TinkerersWorkshop);
    recipe.SetResult(Terraria.ID.ItemID.BandOfStarpower, 1);
    recipe.AddRecipe();
    
    recipe = new ModRecipe (this);
    recipe.AddIngredient(Terraria.ID.ItemID.Actuator, 15);
    recipe.AddIngredient(Terraria.ID.ItemID.Wire, 5);
    recipe.AddIngredient(Terraria.ID.ItemID.MechanicalLens, 1);
    recipe.AddTile(Terraria.ID.ItemID.TinkerersWorkshop);
    recipe.SetResult(Terraria.ID.ItemID.Presserator, 1);
    recipe.AddRecipe();
    
    recipe = new ModRecipe (this);
    recipe.AddIngredient(Terraria.ID.ItemID.BandOfRegeneration, 1);
    recipe.AddIngredient(Terraria.ID.ItemID.LifeCrystal, 1);
    recipe.AddTile(Terraria.ID.ItemID.TinkerersWorkshop);
    recipe.SetResult(Terraria.ID.ItemID.PanicNecklace, 1);
    recipe.AddRecipe();
    
    recipe = new ModRecipe (this);
    recipe.AddIngredient(Terraria.ID.ItemID.BottledHoney, 10);
    recipe.AddIngredient(Terraria.ID.ItemID.BeeWax, 3);
    recipe.AddTile(Terraria.ID.ItemID.TinkerersWorkshop);
    recipe.SetResult(Terraria.ID.ItemID.HoneyComb, 1);
    recipe.AddRecipe();
    }
    }
