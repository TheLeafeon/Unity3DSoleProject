using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipUI : MonoBehaviour
{
    Equip equip;
    public GameObject EquipPanel;
    bool activeEquipUI = false;

    public EquipSlot equipSlot;

    private void Start()
    {
        equip = Equip.equipinstance;
        equip.onChangeEquip += RedrawEquipSlotUI;
        //equipSlot = gameObject.GetComponent<EquipSlot>();

        EquipPanel.SetActive(activeEquipUI);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            activeEquipUI = !activeEquipUI;
            EquipPanel.SetActive(activeEquipUI);
        }
    }

    private void RedrawEquipSlotUI()
    {

        // equipSlot.UpdateSlotUI();

        // null üũ�� �ؾ��մϴ�.
        if (equipSlot != null)
        {
            equipSlot.itemInformation = equip.equipItem;
            equipSlot.UpdateSlotUI();
        }
        else
        {

            Debug.LogWarning("EquipSlot�� ã�� �� �����ϴ�.");
        }
    }


}
