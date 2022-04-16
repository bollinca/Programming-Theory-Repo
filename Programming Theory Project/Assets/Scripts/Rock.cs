using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Rock : Item
{
    public override void TakeDamage()
    {
        durability -= 2;
    }
}
