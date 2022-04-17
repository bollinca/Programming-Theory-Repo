using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryLoader : MonoBehaviour
{
    private StockTracker stockTracker;

    private void Awake()
    {
        stockTracker = GameObject.Find("StockTracker").GetComponent<StockTracker>();
        stockTracker.FullStockUpdate();
    }
}