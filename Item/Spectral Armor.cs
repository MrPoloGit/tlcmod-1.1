public void Effects(Player player) {
    player.magicDamage += (int)(player.rangedCrit * 0.05f);
    player.manaCost -= 0.10f;
    player.magicCrit += (int)(player.rangedCrit * 0.1f);
}

public void SetBonus(Player player) {
	player.setBonus = "23% reduced mana usage";
    player.manaCost -= 0.23f;
    player.ShadowAura = true;
}