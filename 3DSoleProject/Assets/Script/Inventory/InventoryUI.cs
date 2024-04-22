using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public GameObject inventoryPanel;
    bool activeinventory = false;


    private void Start()
    {
        inventoryPanel.SetActive(activeinventory);
    }



    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            activeinventory = !activeinventory;
            inventoryPanel.SetActive(activeinventory);
        }
    }
}
