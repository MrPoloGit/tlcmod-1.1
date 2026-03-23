public void Effects(Player player) {
    player.statManaMax2 += 120;
    player.magicDamage += 0.15f;
    player.magicCrit += (int)(player.rangedCrit * 0.15f);
}
