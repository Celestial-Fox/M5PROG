# PROG

## M5PROG

### opdracht 1

Het doel van deze opdracht is om aan het start 100 ballen met een verschillende kluer en positie instantieren en daarna elke seconde een  nieuwe te instantieren.

    ![Image title](//M5PROG/readMe_Assets/ballFallin.mp4)
    Link naar code: https://github.com/Celestial-Fox/M5PROG/blob/main/M5_PROG/Assets/scripts/Lesson_01/Create_Ball.cs


## M6Prog

### Mermaid

---
title:  M4 Mythe

---

classDiagram
playerMovement : +float movementSpeed

### Early_Returns

```
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
```
