﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace kunwu.Items.Placeable
{
    public class PouriumBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            Item.ResearchUnlockCount = 25;
        }
        public override void SetDefaults()
        {
            Item.value = 2000;
            Item.width = 32;
            Item.height = 32;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useTime = 15;
            Item.useAnimation = 15;
            Item.consumable = true;
            Item.maxStack = 9999;
            Item.rare = ItemRarityID.Pink;
            Item.createTile = ModContent.TileType<Tiles.Bar.PouriumBar>();
            Item.placeStyle = 0;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<PouriumOre>(4)
                .AddTile(TileID.AdamantiteForge)
                .Register();
        }
    }
}
