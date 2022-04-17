using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayUpdater : MonoBehaviour
{
    public StockTracker stockTracker;
    public Text rockText;
    public Text waterText;
    public Text foodText;


    //variables from StockTracker. If you refactor, be sure to take StockTracker destruction on load into account.
    public GameObject[] foodStock;
    public GameObject[] waterStock;
    public GameObject[] rockStock;


    // Start is called before the first frame update
    void Start()
    {
        stockTracker = GameObject.Find("StockTracker").GetComponent<StockTracker>();
        updateDisplay();
    }

    public void updateDisplay()
    {
        //keeps count up to date w/o running on update
        CountItems();
        rockText.text = "You have " + rockStock.Length.ToString() + " rocks.";
        waterText.text = "You have " + waterStock.Length.ToString() + " units of water.";
        foodText.text = "You have " + foodStock.Length.ToString() + " chunks of food.";
    }

    //code from StockTracker. If you refactor, be sure to take StockTracker destruction on load into account.
    void CountItems()
    {
        //counts current stock
        waterStock = GameObject.FindGameObjectsWithTag("Water");
        foodStock = GameObject.FindGameObjectsWithTag("Food");
        rockStock = GameObject.FindGameObjectsWithTag("Rock");
    }
}
