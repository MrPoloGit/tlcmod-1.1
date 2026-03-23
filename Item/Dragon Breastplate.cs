public void Effects(Player player) {
    player.meleeCrit  += (int)(player.meleeCrit * 0.1f);
    player.rangedCrit += (int)(player.rangedCrit * 0.1f);
    player.magicCrit  += (int)(player.magicCrit * 0.1f);
	player.meleeDamage += 0.05f;
}

public void SetBonus(Player player) {
	player.setBonus = "21% increased melee and movement speed";
	player.meleeSpeed += 0.21f;
	player.pickSpeed += 0.21f;
    player.moveSpeed += 0.21f;
    player.ShadowTail = true;
}