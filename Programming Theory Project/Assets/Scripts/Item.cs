using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Item : MonoBehaviour
{
    protected int durability = 50; //ENCAPSULATION

    private void Update() // INHERITANCE
    {
        if (durability <= 0)
        {
            Destroy(gameObject);
        }
    }

    [HideInInspector] virtual public void TakeDamage() // POLYMORPHISM
    {
        durability -= 10;
    }
}