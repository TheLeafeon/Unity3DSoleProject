using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equip : MonoBehaviour
{
    #region Singleton
    public static Equip equipinstance;
    private void Awake()
    {
        if (equipinstance != null)
        {
            Destroy(gameObject);
            return;
        }
        equipinstance = this;
    }
    #endregion


    public delegate void OnChangeEquip();
    public OnChangeEquip onChangeEquip;

    //�̰� �� �ۺ�����
    public ItemInformation equipItem;

    [SerializeField]
    private ItemInformation otherInventory;

    public bool isEquip;


    void Start()
    {
        isEquip = false;
        
    }



    //������ �κ��丮�� �̹� 12ĭ�϶� ���⸦ ��ü�Ϸ��� �ϸ� ��ü�� �ȵǴ� ����
    public bool EquipItem(ItemInformation _item)
    {
        UnityEngine.Debug.Log("EquipIte " );
        //ù ����
        if (!isEquip)
        {
            UnityEngine.Debug.Log("ù ����! ");
            equipItem = _item;

            if(onChangeEquip != null)
            {
                onChangeEquip.Invoke();
            }

            return true;
        }
        else
        {
            return true;
        }
    }
}
