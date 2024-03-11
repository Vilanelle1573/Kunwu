﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace kunwu.Items.Stuff
{
    public class Redgoldfurnace : ModItem
    {
        public override void SetStaticDefaults()
        {
            Item.ResearchUnlockCount = 1;
        }
        public override void SetDefaults()
        {
            Item.value = 5000;
            Item.width = 32;
            Item.height = 32;
            Item.useTime = 15;
            Item.useAnimation = 5;
            Item.consumable = true;
            Item.maxStack = 9999;
            Item.rare = ItemRarityID.Green;
            Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Redgoldfurnace>());
            Item.placeStyle = 0;
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.ItemType<Redgoldingot>(), 8);
            recipe.AddIngredient(ItemID.Hellforge);
            recipe.AddTile(TileID.Furnaces);
            recipe.Register();
        }
    }
}
