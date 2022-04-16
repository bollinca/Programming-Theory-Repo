using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class ItemClass : MonoBehaviour
{
    public int durability = 50;

    virtual public void TakeDamage()
    {
        durability -= 25;
    }

    class WaterClass : ItemClass
    {
        public GameObject waterPrefab;
        public override void TakeDamage()
        {
            durability -= 15;
        }
    }

    class RockClass : ItemClass
    {
        public GameObject foodPrefab;
        public override void TakeDamage()
        {
            durability -= 5;
        }
    }

    class FoodClass : ItemClass
    {
        public GameObject rockPrefab;
        void Speak()
        {
            print("I am food.");
        }
    }
}