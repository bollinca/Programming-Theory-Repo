using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StockTracker : MonoBehaviour
{
    public GameObject[] foodStock;
    public GameObject[] waterStock;
    public GameObject[] rockStock;

    void Start()
    {
        CountItems();
    }

    void Update()
    {
        //Outputs current stock in console every frame
        print("water: " + waterStock.Length + " food: " + foodStock.Length + " rock: " + rockStock.Length);
        CountItems();
    }

    void CountItems()
    {
        //counts current stock
        waterStock = GameObject.FindGameObjectsWithTag("Water");
        foodStock = GameObject.FindGameObjectsWithTag("Food");
        rockStock = GameObject.FindGameObjectsWithTag("Rock");
    }
}
