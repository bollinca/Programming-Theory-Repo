using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Water : Item
{
    [HideInInspector] public override void TakeDamage()
    {
        durability -= 5;
    }
}

