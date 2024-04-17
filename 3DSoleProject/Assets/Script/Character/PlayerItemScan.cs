using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerItemScan : MonoBehaviour
{

    public float raycastDistance = 10.0f;


    [SerializeField]
    private Transform cameraArm;
    [SerializeField]
    private GameObject itemInformationPanel;
    [SerializeField]
    private TextMeshProUGUI itemNameText;
    [SerializeField]
    private Image itemSpriteImage;

    public LayerMask itemLayerMask;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        //레이 그리기
        UnityEngine.Debug.DrawRay(cameraArm.transform.position, cameraArm. transform.forward * raycastDistance, Color.red);


        if (Physics.Raycast(cameraArm.transform.position, cameraArm.transform.forward, out hit, raycastDistance, itemLayerMask))
        {
            ItemInformation raycastItem = hit.collider.GetComponent<ItemInformation>();


            //UnityEngine.Debug.Log("Hit Item: " + hit.collider.gameObject.name);

            //아이템 스캔하면 정보 출력
            if(raycastItem != null)
            {
                itemInformationPanel.SetActive(true);
                itemNameText.text = raycastItem.itemName;
                itemSpriteImage.sprite = raycastItem.ItemImage;
            }

        }
        else
        {
            itemInformationPanel.SetActive(false);
        }
    }

}
