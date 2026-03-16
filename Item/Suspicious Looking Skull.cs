public bool CanUse(Player player, int pID) {
	bool canuse = true;
	if (!Main.dayTime) canuse = true;
	else
	{
		canuse = false;
	}
	if (NPC.AnyNPCs(Config.npcDefs.byName["Suspicious Looking Skull"].type)) canuse = false;
	return canuse;
}

public void UseItem(Player player, int playerID) { 
	if (!Main.dayTime) {
		NPC.SpawnOnPlayer(playerID, Config.npcDefs.byName["Suspicious Looking Skull"].type);
		Main.PlaySound(15, -1, -1, 0);
	}
}
