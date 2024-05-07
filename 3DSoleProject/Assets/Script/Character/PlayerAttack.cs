using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField]
    private Transform characterBody;

    private Rigidbody playerRigidbody;
    private Animator playerAnimator;

    private void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        playerAnimator = characterBody.GetComponent<Animator>();
    }

    public void SetAttackAnimation()
    {
        playerAnimator.SetTrigger("isAttack");
    }

}
