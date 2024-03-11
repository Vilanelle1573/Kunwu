﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace kunwu.Projectiles
{
    public class Bluejianqi : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            Main.projFrames[Projectile.type] = 1;
        }
        public override void SetDefaults()
        {
            Projectile.DamageType = DamageClass.Melee;
            Projectile.width = 50;
            Projectile.height = 50;
            Projectile.friendly = true;
            Projectile.penetrate = -1;
            Projectile.ignoreWater = true;
            Projectile.tileCollide = false; // false为穿墙
            Projectile.light = 1f; // 0到1
        }
        public override void AI()
        {
            Projectile.rotation = Projectile.velocity.ToRotation(); // 将速度属性转为旋转数值

            Projectile.ai[0] += 1f;
            if (Projectile.ai[0] > 90f)
            {
                Projectile.Kill();
            }

            if (Projectile.ai[0] >= 45f)
            {
                Projectile.velocity *= 0.9f;
            }
        }
    }
}
