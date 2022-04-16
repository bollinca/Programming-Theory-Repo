using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Food : Item
{
    private void Start()
    {
        Speak();
    }
    void Speak()
    {
        print("I am food.");
    }
}