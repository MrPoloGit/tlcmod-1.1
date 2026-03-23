public void Effects(Player player) {
    player.rangedDamage += (int)(player.rangedCrit * 0.05f);
    // 5% chance to not consume ammo
    player.rangedCrit += (int)(player.rangedCrit * 0.1f);
}

public void SetBonus(Player player) {
	player.setBonus = "28% chance to not consume ammo";
    // 28% chance to not consume ammo
    player.ShadowAura = true;
}