using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StockTracker : MonoBehaviour
{
    public GameObject[] foodStock;
    public GameObject[] waterStock;
    public GameObject[] rockStock;

    void Update()
    {
        //Keeps item arrays up to date at all times;
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
