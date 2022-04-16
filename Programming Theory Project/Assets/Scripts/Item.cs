using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Item : MonoBehaviour
{
    public int durability = 50;

    private void Update() // INHERITANCE
    {
        if (durability <= 0)
        {
            Destroy(gameObject);
        }
    }

    virtual public void TakeDamage() // POLYMORPHISM
    {
        durability -= 10;
    }
}