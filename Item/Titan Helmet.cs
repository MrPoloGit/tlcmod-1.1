public void Effects(Player player) {
    player.rangedDamage += 0.15f;
    // 5% chance to not consume ammo
    player.rangedCrit += (int)(player.rangedCrit * 0.1f);
}