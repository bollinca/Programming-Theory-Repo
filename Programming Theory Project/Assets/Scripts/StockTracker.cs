using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StockTracker : MonoBehaviour
{

    // For tracking prefabs and interacting with them
    public GameObject[] foodStock;
    public GameObject[] waterStock;
    public GameObject[] rockStock;

    // For displaying the current item count
    private Text rockText;
    private Text waterText;
    private Text foodText;

    public void FullStockUpdate() //ABSTRACTION
    {
        AssignTextFields();
        CountItems();
        UpdateDisplay();
    }

    public void CountItems()
    {
        //counts current stock
        waterStock = GameObject.FindGameObjectsWithTag("Water");
        foodStock = GameObject.FindGameObjectsWithTag("Food");
        rockStock = GameObject.FindGameObjectsWithTag("Rock");
    }

    private void AssignTextFields()
    {
        rockText = GameObject.Find("RockTotal").GetComponent<Text>();
        foodText = GameObject.Find("FoodTotal").GetComponent<Text>();
        waterText = GameObject.Find("WaterTotal").GetComponent<Text>();
    }

    private void UpdateDisplay()
    {
        rockText.text = "You have " + rockStock.Length.ToString() + " rocks.";
        waterText.text = "You have " + waterStock.Length.ToString() + " units of water.";
        foodText.text = "You have " + foodStock.Length.ToString() + " chunks of food.";
    }
}
