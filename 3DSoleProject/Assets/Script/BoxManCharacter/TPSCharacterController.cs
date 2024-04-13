using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPSCharacterController : MonoBehaviour
{
    [SerializeField]
    private Transform characterBody;
    [SerializeField]
    private Transform cameraArm;

    public float characterMoveSpeed = 5.0f;

    Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        animator = characterBody.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        LookAround();
        Move();
    }

    private void LookAround()
    {

        Vector2 mouseDelta = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        Vector3 camAngle = cameraArm.rotation.eulerAngles;

        float x = camAngle.x - mouseDelta.y;

        //ȸ�� ����
        if(x < 180.0f)
        {
            x = Mathf.Clamp(x, -1.0f, 70.0f);
        }
        else
        {
            x = Mathf.Clamp(x, 335.0f, 361.0f);
        }

        cameraArm.rotation = Quaternion.Euler(x, camAngle.y + mouseDelta.x, camAngle.z);
    }

    private void Move()
    {
        UnityEngine.Debug.DrawRay(cameraArm.position, new Vector3(cameraArm.forward.x, 0.0f, cameraArm.forward.z).normalized, Color.red);


        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        bool isMove = moveInput.magnitude != 0;

        animator.SetBool("isMove" , isMove);

        if(isMove)
        {
            Vector3 lookForward = new Vector3(cameraArm.forward.x, 0.0f, cameraArm.forward.z).normalized;
            Vector3 lookRight = new Vector3(cameraArm.right.x ,0.0f, cameraArm.right.z).normalized;


            Vector3 moveDir = lookForward* moveInput.y + lookRight* moveInput.x;

            //ĳ���Ͱ� �̵��Ҷ� ī�޶� �ٶ󺸴� ���� �ٶ󺸰� �ϱ�
            //characterBody.forward = lookForward;
            //ĳ���Ͱ� �̵��� �� �̵� ������ �ٶ󺸰� �ϱ�
            characterBody.forward = moveDir;

            transform.position += moveDir * Time.deltaTime * characterMoveSpeed;

        }
    }
}
