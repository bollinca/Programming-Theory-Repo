using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainLoader : MonoBehaviour
{

    // Used to prevent destruction on load
    private GameObject inventory;
    private GameObject stockTrackerContainer;
    // Used for function access
    private StockTracker stockTracker;

    private void Start()
    {
        inventory = GameObject.Find("Inventory");
        stockTrackerContainer = GameObject.Find("StockTracker");
        stockTracker = stockTrackerContainer.GetComponent<StockTracker>();
        stockTracker.CountItems();
    }

   private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //ensure that inventory is not cleared on scene swap from inventory to gamescene
            DontDestroyOnLoad(inventory);
            DontDestroyOnLoad(stockTrackerContainer);
            SceneManager.LoadScene(0);
        }
    }
}
