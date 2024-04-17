using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IteractItemUI : MonoBehaviour
{
    //가까이 오면 아이템 정보를 UI를 통해서 출력

    //아이템 정보
    [SerializeField]
    private Transform ItemBody;

    ////패널
    //[SerializeField]
    //private Transform cameraArm;

    public float halfSize = 1.0f;
    //private Transform itemCenter;

    private void Awake()
    {

    }


    private void OnDrawGizmos()
    {
       if(ItemBody != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawSphere(transform.position, halfSize);
        }
    }
}
