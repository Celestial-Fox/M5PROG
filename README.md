# M5PROG


## opdracht 1
Het doel van deze opdracht is om aan het start 100 ballen met een verschillende kluer en positie instantieren en daarna elke seconde een  nieuwe te instantieren.
https://github.com/user-attachments/assets/5648148d-5945-439c-abc0-44495238f60c
Link naar code: https://github.com/Celestial-Fox/M5PROG/blob/main/M5_PROG/Assets/scripts/Lesson_01/Create_Ball.cs

# M6Prog

## Mermaid
---
title: Animal example
---
classDiagram
    note "From Duck till Zebra"
    Animal <|-- Duck
    note for Duck "can fly\ncan swim\ncan dive\ncan help in debugging"
    Animal <|-- Fish
    Animal <|-- Zebra
    Animal : +int age
    Animal : +String gender
    Animal: +isMammal()
    Animal: +mate()
    class Duck{
        +String beakColor
        +swim()
        +quack()
    }
    class Fish{
        -int sizeInFeet
        -canEat()
    }
    class Zebra{
        +bool is_wild
        +run()
    }
