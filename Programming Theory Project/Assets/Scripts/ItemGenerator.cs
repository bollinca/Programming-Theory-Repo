using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemGenerator : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject foodPrefab;
    public GameObject rockPrefab;
    public GameObject waterPrefab;
    public string lastButton;
    GameObject inventory;

    void Start()
    {
        inventory = GameObject.Find("Inventory");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CreateItem()
    {
        lastButton = EventSystem.current.currentSelectedGameObject.name;
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
        // find button type
        // run item creation method

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
