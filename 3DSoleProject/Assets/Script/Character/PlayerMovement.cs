using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerMoveSpeed = 5.0f;
    private Rigidbody playerRigidbody;
    private Animator playerAnimator;

    private void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        playerAnimator = GetComponent<Animator>();
    }

    public void CharacterMove(float horizontalInput, float verticalInput)
    {
        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput) * playerMoveSpeed * Time.deltaTime;
        playerRigidbody.MovePosition(transform.position + movement);
    }

    public void SetWalkingAnimation(bool isWalking)
    {
        playerAnimator.SetBool("isWalking", isWalking);
    }
}
