using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    Inventory inven;
    public GameObject inventoryPanel;
    bool activeinventory = false;

    public Slot[] slots;
    public Transform slotHolder;

    private void Start()
    {
        inven = Inventory.instance;
        slots = slotHolder.GetComponentsInChildren<Slot>();
        //inven.onSlotCountChange += SlotChange;

        inven.onChangeItem += RedrawSlotUI;

        inventoryPanel.SetActive(activeinventory);
    }

    //private void SlotChange(int val)
    //{
    //    for(int i = 0; i<slots.Length; i++)
    //    {
           
    //        if(i< inven.SlotCount)
    //        {
    //            slots[i].GetComponent<Button>().interactable = true;
    //        }
    //        else
    //        {
    //            slots[i].GetComponent<Button>().interactable = false;
    //        }
    //    }
    //}

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            activeinventory = !activeinventory;
            inventoryPanel.SetActive(activeinventory);
        }
    }
    private void RedrawSlotUI()
    {
        

        for (int i = 0; i < slots.Length; i++)
        {
            

            slots[i].RemoveSlot();
            slots[i].slotNum = i;
        }

        for (int i=0; i<inven.items.Count; i++)
        {
            slots[i].itemInformation = inven.items[i];
            slots[i].UpdateSlotUI();
        }
    }
}
