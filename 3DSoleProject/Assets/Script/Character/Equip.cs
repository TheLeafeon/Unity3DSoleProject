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

    //이거 왜 퍼블릭이지
    public ItemInformation equipItem;

    [SerializeField]
    private ItemInformation otherInventory;

    //무기 정보: 공격력, 무기 타입 등.
    public WeaponInformation equipWeaponInformation;

    public bool isEquip;

    void Start()
    {
        isEquip = false;
    }

    //, WeaponInformation _weaponInformation

    //문제점 인벤토리가 이미 12칸일때 무기를 교체하려고 하면 교체가 안되는 문제
    public bool EquipItem(ItemInformation _item, WeaponInformation _weaponInformation)
    {
        //첫 장착
        if (!isEquip)
        {
            UnityEngine.Debug.Log("장착 무기의 공격력: "+ _weaponInformation.weaponAttackPower);
            equipItem = _item;
            equipWeaponInformation = _weaponInformation;

            if (onChangeEquip != null)
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
