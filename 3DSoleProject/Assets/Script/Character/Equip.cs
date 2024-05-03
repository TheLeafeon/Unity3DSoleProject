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

    //���� ����: ���ݷ�, ���� Ÿ�� ��.
    public WeaponInformation equipWeaponInformation;

    public bool isEquip;

    void Start()
    {
        isEquip = false;
    }

    //, WeaponInformation _weaponInformation

    //������ �κ��丮�� �̹� 12ĭ�϶� ���⸦ ��ü�Ϸ��� �ϸ� ��ü�� �ȵǴ� ����
    public bool EquipItem(ItemInformation _item, WeaponInformation _weaponInformation)
    {
        //ù ����
        if (!isEquip)
        {
            UnityEngine.Debug.Log("���� ������ ���ݷ�: "+ _weaponInformation.weaponAttackPower);
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
