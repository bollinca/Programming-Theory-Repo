using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainLoader : MonoBehaviour
{
    private GameObject inventory;

    void Start()
    {
        inventory = GameObject.Find("Inventory");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //ensure that inventory is not cleared on scene swap from inventory to gamescene
            DontDestroyOnLoad(inventory);
            SceneManager.LoadScene(0);
        }
    }
}
