using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class InventoryController : MonoBehaviour
{

    private GameObject boundaries;
    private GameObject inventory;
    private GameObject stockTracker;
    
    // Variables for randomizing shake
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
        // link stocktracker for variable access;
        stockTracker = GameObject.Find("StockTracker");
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
        GameObject[] foodStock = stockTracker.GetComponent<StockTracker>().foodStock;
        GameObject[] rockStock = stockTracker.GetComponent<StockTracker>().rockStock;
        GameObject[] waterStock = stockTracker.GetComponent<StockTracker>().waterStock;

        xRange = Random.Range(-5, 5);
        yRange = Random.Range(-5, 5);
        zRange = Random.Range(-5, 5);
        randomizedShake = new Vector3 (xRange, yRange, zRange);

        // Loop through all food objects, "shake" and damage them
        foreach (GameObject gameObjectFood in foodStock)
        {
            gameObjectFood.GetComponent<Rigidbody>().AddForce(randomizedShake, ForceMode.Impulse);
            //Access script
            Food food = gameObjectFood.GetComponent<Food>();
            food.TakeDamage();
        }
        // See preceding two comments
        foreach (GameObject gameObjectRock in rockStock)
        {
            gameObjectRock.GetComponent<Rigidbody>().AddForce(randomizedShake, ForceMode.Impulse);
            Rock rock = gameObjectRock.GetComponent<Rock>();
            rock.TakeDamage();
        }
        foreach (GameObject gameObjectWater in waterStock)
        {
            gameObjectWater.GetComponent<Rigidbody>().AddForce(randomizedShake, ForceMode.Impulse);
            Water water = gameObjectWater.GetComponent<Water>();
            water.TakeDamage();
        }
    }
}
