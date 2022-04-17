using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Rock : Item
{
    [HideInInspector] public override void TakeDamage()
    {
        durability -= 2;
    }
}
