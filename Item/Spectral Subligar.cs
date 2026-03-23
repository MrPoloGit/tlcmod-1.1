public void Effects(Player player) {
	player.moveSpeed += 0.10f;
    player.magicDamage += (int)(player.rangedCrit * 0.1f);
    player.statManaMax2 += 30;
}