public bool SpawnNPC(int x, int y, int playerID)
{
    Player player = Main.player[playerID];

    return Main.hardMode &&
        //    player.zoneDesert &&     // now sure how
           player.zoneEvil &&       // corruption
           !player.zoneMeteor &&
           Main.rand.Next(7) == 0;
}
public void NPCLoot()
{
	int D = Dust.NewDust(npc.position, npc.height, npc.width, 3, 1f, 1f, 100, default(Color), 1f);
	int D2 = Dust.NewDust(npc.position, npc.height, npc.width, 3, 1f, 1f, 100, default(Color), 1f);
	Main.dust[D].noGravity = true;
	Main.dust[D2].noGravity = true;
}