using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Weapon,
    Consumables,
    Etc
}

[System.Serializable]
public class ItemInformation : MonoBehaviour
{
    public ItemType itemType;
    public string itemName;
    public Sprite itemImage;
    public List<ItemEffect> effects;
    



    //������ ����
    public void DestroyItem()
    {
        Destroy(gameObject);
    }

    //������ ���
    public bool Use()
    {
        bool isUesd = false;

        switch (itemType)
        {
            case ItemType.Weapon:
                UnityEngine.Debug.Log(itemName + "��(��) ��������� �Դϴ�.");

                //isUesd = Equip.equipinstance.EquipItem(this);
                isUesd = Equip.equipinstance.EquipItem(this.gameObject.GetComponent<ItemInformation>());

                break; 
            case ItemType.Consumables:
                UnityEngine.Debug.Log(itemName + "��(��) �Һ������ �Դϴ�.");

                foreach (ItemEffect effect in effects)
                {
                    isUesd = effect.ExcuteRole();
                }

                break;
            case ItemType.Etc:
                UnityEngine.Debug.Log(itemName + "��(��) ��Ÿ������ �Դϴ�.");
                break;
        }


        return isUesd;
    }
}
