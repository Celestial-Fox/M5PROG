public bool IsPlayerReadyToAttack(Player player)
{
    if (player == null) return false;
    if (!player.IsAlive) return false;
    if (player.AttackCooldown < 0) return false;
    
    if (player.Target != null) return false;
    if (!player.Target.IsAlive) return false;

    float distance = Vector3.Distance(player.transform.position, player.Target.transform.position)
    if (distance >= 5f) return;

    bool hasManaAndWeapon
    if (player.Mana >= 20 && player.WeaponEquipped) 
    hasManaAndWeapon = true;

    bool hasManaAndWeapon
    if (player.Health > 30 && player.HasBuff("Strength")) 
    hasHpAndBuff = true;

    if (hasManaAndWeapon && hasHpAndBuff) return false;

    if (player.IsStunned) return false;
    if (player.IsSlowed) return false;
                                
    return true;
}