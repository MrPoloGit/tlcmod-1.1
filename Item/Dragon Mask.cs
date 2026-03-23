public void Effects(Player player) {
	player.meleeSpeed += 0.15f;
    player.meleeDamage += 0.15f;
    player.meleeCrit  += (int)(player.meleeCrit * 0.1f);
    player.rangedCrit += (int)(player.rangedCrit * 0.1f);
    player.magicCrit  += (int)(player.magicCrit * 0.1f);
}