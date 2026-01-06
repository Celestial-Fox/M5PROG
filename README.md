# M5PROG


## opdracht 1
Het doel van deze opdracht is om aan het start 100 ballen met een verschillende kluer en positie instantieren en daarna elke seconde een  nieuwe te instantieren.
https://github.com/user-attachments/assets/5648148d-5945-439c-abc0-44495238f60c
Link naar code: https://github.com/Celestial-Fox/M5PROG/blob/main/M5_PROG/Assets/scripts/Lesson_01/Create_Ball.cs

# M6Prog

## Mermaid
---
title:  M4 Mythe
---

classDiagram
playerMovement : +float movementSpeed




## Early_Returns

```
public bool IsPlayerReadyToAttack(Player player)
{
    if (player == null) return;
    if (!player.IsAlive) return;
    if (player.AttackCooldown < 0) return;
    if (player.Target != null) return;
    if (!player.Target.IsAlive) return;
    if (Vector3.Distance(player.transform.position, player.Target.transform.position) >= 5f) return;
    if (player.Mana < 20) return;

    if (!player.WeaponEquipped) return; ||

                                (player.Health > 30 && player.HasBuff("Strength")))
                            {
                                //Level7
                                if (player.IsStunned) return;
                                if (player.IsSlowed) return;
                                
    return true;
}
```
