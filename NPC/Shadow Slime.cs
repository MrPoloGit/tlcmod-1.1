public bool SpawnNPC(int x, int y, int playerID)
{
    Player player = Main.player[playerID];

    if (player.zoneEvil) // corruption biome
    {
        if (y < Main.rockLayer - 10 &&
            y > (int)(Main.topWorld + 100f) &&
            !Main.dayTime &&
            !player.zoneMeteor &&
            Main.rand.Next(40) == 0)
        {
            return true;
        }
    }

    return false;
}


public void NPCLoot()
{
	Dust.NewDust(npc.position, npc.width, npc.height, 4, 0.2f, 0.2f, 100, default(Color), 1f);
	Dust.NewDust(npc.position, npc.width, npc.height, 4, 0.2f, 0.2f, 100, default(Color), 1f);
	Dust.NewDust(npc.position, npc.width, npc.height, 4, 0.2f, 0.2f, 100, default(Color), 1f);
}


