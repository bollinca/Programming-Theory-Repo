using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemGenerator : MonoBehaviour
{

    public GameObject foodPrefab;
    public GameObject rockPrefab;
    public GameObject waterPrefab;
    GameObject inventory;
    DisplayUpdater displayUpdater;

    public string lastButton;

    void Start()
    {
        inventory = GameObject.Find("Inventory");
        displayUpdater = GameObject.Find("DisplayUpdater").GetComponent<DisplayUpdater>();
    }

    public void CreateItem() //ABSTRACTION
    {
        //find name of button pressed
        lastButton = EventSystem.current.currentSelectedGameObject.name;
        //run appropriate generation method
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
        displayUpdater.updateDisplay();
    }

    void CreateWater()
    {
        Instantiate(waterPrefab, inventory.transform);
    }
    void CreateFood()
    {
        Instantiate(foodPrefab, inventory.transform);
    }
    void CreateRock()
    {
        Instantiate(rockPrefab, inventory.transform);
    }

}
