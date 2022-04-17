using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemGenerator : MonoBehaviour
{
    // Prefabs assigned in editor
    [SerializeField] private GameObject foodPrefab; // Encapsulation
    [SerializeField] private GameObject rockPrefab;
    [SerializeField] private GameObject waterPrefab;

    // accessed for prefab creation (set as parent)
    private GameObject inventory;
    //accessed to use functions
    private StockTracker stockTracker;

    private string lastButton;

    private void Start()
    {
        inventory = GameObject.Find("Inventory");
        stockTracker = GameObject.Find("StockTracker").GetComponent<StockTracker>();
    }

    // CreateItem is used in-engine (attached to all prefabs)
    [SerializeField] void CreateItem() //ABSTRACTION && ENCAPSULATION
    {
        //find name of button pressed
        lastButton = EventSystem.current.currentSelectedGameObject.name;
        //generate appropriate item
        switch (lastButton)
        {
            case "FoodGenerator":
                CreateFood();
                break;
            case "WaterGenerator":
                CreateWater();
                break;
            case "RockGenerator":
                CreateRock();
                break;
        }
        stockTracker.FullStockUpdate() ;
    }

    private void CreateWater()
    {
        Instantiate(waterPrefab, inventory.transform);
    }
    private void CreateFood()
    {
        Instantiate(foodPrefab, inventory.transform);
    }
    private void CreateRock()
    {
        Instantiate(rockPrefab, inventory.transform);
    }

}
