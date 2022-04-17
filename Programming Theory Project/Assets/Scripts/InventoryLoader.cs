using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//This script exists to ensure that FullStockUpdate runs every time the Inventory scene is loaded.

public class InventoryLoader : MonoBehaviour
{
    private StockTracker stockTracker;

    private void Awake()
    {
        stockTracker = GameObject.Find("StockTracker").GetComponent<StockTracker>();
        stockTracker.FullStockUpdate();
    }
}