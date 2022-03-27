using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StockTracker : MonoBehaviour
{
    int foodCount;
    int waterCount;
    int rockCount;

    // Start is called before the first frame update
    void Start()
    {
        countItems();
    }

    // Update is called once per frame
    void Update()
    {
        print("water: " + waterCount + " food: " + foodCount + " rock: " + rockCount);
        countItems();
    }

    void countItems()
    {
        waterCount = GameObject.FindGameObjectsWithTag("Water").Length;
        foodCount = GameObject.FindGameObjectsWithTag("Food").Length;
        rockCount = GameObject.FindGameObjectsWithTag("Rock").Length;
    }
}
