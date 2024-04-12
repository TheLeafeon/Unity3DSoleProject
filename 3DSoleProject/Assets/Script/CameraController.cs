using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float rotationSpeed = 5.0f;

    void Update()
    {
        // 마우스 입력 감지
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        // 카메라 회전
        RotateCamera(mouseX, mouseY);
    }

    void RotateCamera(float mouseX, float mouseY)
    {
        // 수평 회전 (카메라가 y축 주위로 회전)
        transform.Rotate(Vector3.up, mouseX * rotationSpeed * Time.deltaTime, Space.World);

        // 수직 회전 (카메라가 x축 주위로 회전)
        transform.Rotate(Vector3.left, mouseY * rotationSpeed * Time.deltaTime, Space.Self);
    }
}
