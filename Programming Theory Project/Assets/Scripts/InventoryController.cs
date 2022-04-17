using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class InventoryController : MonoBehaviour
{
    // accessed to prevent destruction on load.
    private GameObject boundaries;
    private GameObject inventory;

    //accessed for function use and item damage application
    private GameObject stockTrackerContainer;
    private StockTracker stockTracker;

    // Variables for randomizing shake magnitude/direction
    private Vector3 randomizedShake;
    private int xRange;
    private int yRange;
    private int zRange;

    void Start()
    {
        // Ensure that inventory does not clear on scene swap from gamescene to inventory
        inventory = GameObject.Find("Inventory");
        boundaries = GameObject.Find("Boundaries");
        DontDestroyOnLoad(inventory);
        DontDestroyOnLoad(boundaries);
        // link stocktracker object for variable access;
        stockTrackerContainer = GameObject.Find("StockTracker");
        if (stockTrackerContainer)
        {
            stockTracker = stockTrackerContainer.GetComponent<StockTracker>();
        }
    }

    void Update()
    {
        //load inventory scene (and unload current scene)
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(1);
        }
    }

    public void ShakeInventory()
    {
        xRange = Random.Range(-5, 5);
        yRange = Random.Range(-5, 5);
        zRange = Random.Range(-5, 5);
        randomizedShake = new Vector3(xRange, yRange, zRange);


        // CountItems must be placed before the loops. Putting it at the end introduces a bug where the count array remains bound to destroyed objects.
        stockTracker.CountItems();
        // Loop through all food objects, "shake" and damage them
        foreach (GameObject gameObjectFood in stockTracker.foodStock)
        {
            gameObjectFood.GetComponent<Rigidbody>().AddForce(randomizedShake, ForceMode.Impulse);
            //Access script
            Food food = gameObjectFood.GetComponent<Food>();
            food.TakeDamage();
        }
        foreach (GameObject gameObjectRock in stockTracker.rockStock)
        {
            gameObjectRock.GetComponent<Rigidbody>().AddForce(randomizedShake, ForceMode.Impulse);
            Rock rock = gameObjectRock.GetComponent<Rock>();
            rock.TakeDamage();
        }
        foreach (GameObject gameObjectWater in stockTracker.waterStock)
        {
            gameObjectWater.GetComponent<Rigidbody>().AddForce(randomizedShake, ForceMode.Impulse);
            Water water = gameObjectWater.GetComponent<Water>();
            water.TakeDamage();
        }
    }
}
