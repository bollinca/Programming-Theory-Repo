using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Water : Item
{
    // Damage done to items varies by item. Durability is always 50.

    [HideInInspector] public override void TakeDamage()
    {
        durability -= 5;
    }
}

