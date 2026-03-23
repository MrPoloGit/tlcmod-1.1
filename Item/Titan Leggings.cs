public void Effects(Player player) {
	player.moveSpeed += 0.10f;
    player.rangedDamage += (int)(player.rangedCrit * 0.1f);
    // 10% chance to not consume ammo
}