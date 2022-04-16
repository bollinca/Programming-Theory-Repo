using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class DisplayUpdater : MonoBehaviour
{
    public StockTracker stockTracker;
    public Text rockText;
    public Text waterText;
    public Text foodText;
    // Start is called before the first frame update
    void Start()
    {
        stockTracker = GameObject.Find("StockTracker").GetComponent<StockTracker>();
    }

    // Update is called once per frame
    void Update()
    {
        rockText.text = "You have " + stockTracker.rockStock.Length.ToString() + " rocks.";
        waterText.text = "You have " + stockTracker.waterStock.Length.ToString() + " units of water.";
        foodText.text = "You have " + stockTracker.foodStock.Length.ToString() + " chunks of food.";
    }
}
