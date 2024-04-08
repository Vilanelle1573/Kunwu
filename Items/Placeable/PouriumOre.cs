﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace kunwu.Items.Placeable
{
    public class PouriumOre : ModItem
    {
        public override void SetDefaults()
        {
            Item.value = 500;
            Item.width = 32;
            Item.height = 32;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useTime = 15;
            Item.useAnimation = 5;
            Item.consumable = true;
            Item.maxStack = 9999;
            Item.rare = ItemRarityID.Pink;
            // Item.createTile = ModContent.TileType<Tiles.RedgoldBar>();
            Item.placeStyle = 0;
        }
    }
}
