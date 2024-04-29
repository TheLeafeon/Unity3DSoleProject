using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipUI : MonoBehaviour
{

    public GameObject equipPanel;
    bool activeEquip = false;
    public EquipSlot slot;

    private void start()
    {
        equipPanel.SetActive(activeEquip);
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            activeEquip = !activeEquip;
            equipPanel.SetActive(activeEquip);
        }
    }
}
