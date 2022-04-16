using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StockTracker : MonoBehaviour
{
    int foodCount;
    int waterCount;
    int rockCount;

    void Start()
    {
        countItems();
    }

    void Update()
    {
        //Outputs current stock in console every frame
        print("water: " + waterCount + " food: " + foodCount + " rock: " + rockCount);
        countItems();
    }

    void countItems()
    {
        //counts current stock
        waterCount = GameObject.FindGameObjectsWithTag("Water").Length;
        foodCount = GameObject.FindGameObjectsWithTag("Food").Length;
        rockCount = GameObject.FindGameObjectsWithTag("Rock").Length;
    }
}
