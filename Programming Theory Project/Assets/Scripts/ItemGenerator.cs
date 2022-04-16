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
    public string lastButton;

    void Start()
    {
        inventory = GameObject.Find("Inventory");
    }

    public void CreateItem()
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
