using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private Transform characterBody;
    [SerializeField]
    private Transform cameraArm;


    public float playerMoveSpeed = 5.0f;
    private Rigidbody playerRigidbody;
    private Animator playerAnimator;

    private void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        playerAnimator = GetComponent<Animator>();

    }

    public void CharacterMove(Vector2 moveInput)
    {

        Vector3 lookForward = new Vector3(cameraArm.forward.x, 0.0f, cameraArm.forward.z).normalized;
        Vector3 lookRight = new Vector3(cameraArm.right.x, 0.0f, cameraArm.right.z).normalized;

        Vector3 moveDir = lookForward * moveInput.y + lookRight * moveInput.x;

        characterBody.forward = lookForward;

        Vector3 movement = moveDir * playerMoveSpeed * Time.deltaTime;
        playerRigidbody.MovePosition(transform.position + movement);
    }

    public void SetWalkingAnimation(bool isWalking)
    {
        playerAnimator.SetBool("isWalking", isWalking);
    }

}
