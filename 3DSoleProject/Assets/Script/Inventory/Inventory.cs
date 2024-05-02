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


    // InventoryUI/RedrawSlotUI()
    public delegate void OnChangeItem();
    public OnChangeItem onChangeItem;


    public List<ItemInformation> items = new List<ItemInformation>(); //content

    //최대 슬롯 개수
    private int slotCount;

    void Start()
    {
        slotCount = 12;
    }

    //아이템 추가
    public bool AddItem(ItemInformation _item)
    {

        UnityEngine.Debug.Log(items.Count + " / " + slotCount);

        if (items.Count < slotCount)
        {

            items.Add(_item); //slot에 OnTriggerEnter 한걸 넣는다.
            if (onChangeItem != null)
            {
                onChangeItem.Invoke();
            }
            return true;
        }
        return false;
    }
    
    //아이템 획득
    private void OnTriggerEnter(Collider collision)
    {
       
        if(collision.CompareTag("FieldItem"))
        {
            ItemInformation fieldItems = collision.GetComponent<ItemInformation>();


            
            if (AddItem(fieldItems))
            {
                UnityEngine.Debug.Log("OnTriggerEnter" + collision);
                //fieldItems.DestroyItem();
            }
        }
    }

    //아이템 제거
    public void RemoveItem(int _index)
    {
        UnityEngine.Debug.Log("_index: " + _index);
        items.RemoveAt(_index);
        onChangeItem.Invoke();
    }
}
