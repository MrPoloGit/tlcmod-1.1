// public bool SpawnNPC(int x, int y, int playerID)
// {
//     Player player = Main.player[playerID];

//     // Still need to fix the position
//     return !Main.player[playerID].zoneDungeon &&
//            !Main.player[playerID].zoneEvil &&
//            !Main.player[playerID].zoneHoly &&
//            !Main.player[playerID].zoneJungle &&
//            !Main.player[playerID].zoneMeteor &&
//            Main.rand.Next(14) == 0;
// }
// public void UpdateNPC(int i)
// {
//     // Need to add light to the vampire miner
// }

public void NPCLoot()
{
    Gore.NewGore(npc.position, npc.velocity, "Vampire Miner Gore 1", 1.1f, -1);
	Gore.NewGore(npc.position, npc.velocity, "Vampire Miner Gore 2", 1.1f, -1);
    Gore.NewGore(npc.position, npc.velocity, "Vampire Miner Gore 3", 1.1f, -1);
    Dust.NewDust(npc.position, npc.height, npc.width, 4, 0.2f, 0.2f, 100, default(Color), 1f);
	Dust.NewDust(npc.position, npc.height, npc.width, 4, 0.2f, 0.2f, 100, default(Color), 1f);
	Dust.NewDust(npc.position, npc.height, npc.width, 4, 0.2f, 0.2f, 100, default(Color), 1f);
}