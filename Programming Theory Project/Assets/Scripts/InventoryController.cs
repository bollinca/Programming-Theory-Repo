using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class InventoryController : MonoBehaviour
{

    GameObject boundaries;
    GameObject inventory;
    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.Find("Inventory");
        boundaries = GameObject.Find("Boundaries");
        DontDestroyOnLoad(inventory);
        DontDestroyOnLoad(boundaries);
    }

    // Update is called once per frame
    void Update()
    {
        //load inventory scene (and unload current scene)
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(1);
        }
    }
}
