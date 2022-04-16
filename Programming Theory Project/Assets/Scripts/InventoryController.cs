using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class InventoryController : MonoBehaviour
{

    GameObject boundaries;
    GameObject inventory;
    GameObject stockTracker;

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
    }

    public void ClearInventory()
    {
        GameObject.FindGameObjectsWithTag("Item");
    }
}
