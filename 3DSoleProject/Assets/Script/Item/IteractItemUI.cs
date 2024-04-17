using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IteractItemUI : MonoBehaviour
{
    //������ ���� ������ ������ UI�� ���ؼ� ���

    //������ ����
    [SerializeField]
    private Transform ItemBody;

    ////�г�
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
