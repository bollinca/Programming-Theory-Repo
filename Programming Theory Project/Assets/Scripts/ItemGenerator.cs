using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject foodPrefab;
    public GameObject rockPrefab;
    public GameObject waterPrefab;
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
        //if (button pressed)
        // find button type
        // create item to match type
        // add item to Inventory Game Object

    }

    public void CreateWater()
    {
        Instantiate(waterPrefab, inventory.transform);
    }

    public void CreateFood()
    {
        Instantiate(foodPrefab, inventory.transform);
    }
    
    public void CreateRock()
    {
        Instantiate(rockPrefab, inventory.transform);
    }

}
