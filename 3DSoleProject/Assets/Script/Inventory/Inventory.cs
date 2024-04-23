using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    


    #region Singleton
    public static Inventory instance;
    private void Awake()
    {
        if(instance !=null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
    }
    #endregion


    public delegate void OnSlotCountChange(int val);
    public OnSlotCountChange onSlotCountChange;


    public delegate void OnChangeItem();
    public OnChangeItem onChangeItem;


    public List<ItemInformation> items = new List<ItemInformation>();
    //public List<Item> items = new List<Item>();


    private int slotCount;
    public int SlotCount
    {
        get => slotCount;
        set
        {
            slotCount = value;
            onSlotCountChange.Invoke(slotCount);
        }
    }

    void Start()
    {
        slotCount = 12;
    }

    public bool AddItem(ItemInformation _item)
    {

        UnityEngine.Debug.Log(items.Count + " / " + SlotCount);

        if (items.Count < SlotCount)
        {

            items.Add(_item);
            if (onChangeItem != null)
            {
                onChangeItem.Invoke();
            }
            return true;
        }
        return false;
    }
    
    private void OnTriggerEnter(Collider collision)
    {
       
        if(collision.CompareTag("FieldItem"))
        {
            ItemInformation fieldItems = collision.GetComponent<ItemInformation>();


            
            if (AddItem(fieldItems))
            {
                UnityEngine.Debug.Log("OnTriggerEnter" + collision);
                fieldItems.DestroyItem();
            }
        }
    }
}
