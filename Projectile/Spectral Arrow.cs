public void AI()
{
	projectile.AI(true);
}
public void DamageNPC(NPC npc, ref int damage, ref float knockback)
{
	npc.AddBuff("Cursed Inferno", 540);
}
public void DamagePVP(ref int damage, Player enemyPlayer)
{
    if (Main.rand.Next(4) == 0)
    {
        enemyPlayer.AddBuff(39, 540, false); // Cursed Inferno
    }
}