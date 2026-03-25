public void AI()
{
	projectile.AI(true);
}
public void DamageNPC(NPC npc, ref int damage, ref float knockback)
{
	npc.AddBuff(39, 540);
}
public void DamagePVP(ref int damage, Player enemyPlayer)
{
    enemyPlayer.AddBuff(39, 540, false);
}