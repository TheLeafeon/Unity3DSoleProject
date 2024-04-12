using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float rotationSpeed = 5.0f;

    void Update()
    {
        // ���콺 �Է� ����
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        // ī�޶� ȸ��
        RotateCamera(mouseX, mouseY);
    }

    void RotateCamera(float mouseX, float mouseY)
    {
        // ���� ȸ�� (ī�޶� y�� ������ ȸ��)
        transform.Rotate(Vector3.up, mouseX * rotationSpeed * Time.deltaTime, Space.World);

        // ���� ȸ�� (ī�޶� x�� ������ ȸ��)
        transform.Rotate(Vector3.left, mouseY * rotationSpeed * Time.deltaTime, Space.Self);
    }
}
