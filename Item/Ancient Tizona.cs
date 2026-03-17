public void UseItemEffect(Player player, Rectangle rectangle)
{
    int dust = Dust.NewDust(
        new Vector2(rectangle.X, rectangle.Y),
        rectangle.Width,
        rectangle.Height,
        6, // flame dust
        player.velocity.X * 0.2f + player.direction * 3,
        player.velocity.Y * 0.2f,
        100,
        default(Color),
        1.8f
    );

    Main.dust[dust].noGravity = true;
}

public void DamageNPC(Player player, NPC npc, ref int damage, ref float knockback)
{
    npc.AddBuff(30, 420); // Bleeding
}