using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Food : Item
{
    private void Start()
    {
        TechnicallyAnEasterEgg();
    }

    [HideInInspector] public override void TakeDamage()
    {
        base.TakeDamage();
    }

    private void TechnicallyAnEasterEgg()
    {
        print("Oh hey you noticed this. Cool.");
    }
}