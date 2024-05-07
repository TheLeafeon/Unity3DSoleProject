using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    #region Singleton
    public static Player PlayerInstance;
    private void Awake()
    {
        if(PlayerInstance != null)
        {
           
            Destroy(gameObject);
            return;
        }
        PlayerInstance = this;
    }
    #endregion

    public bool isAttacking;

    private void Start()
    {
        isAttacking = false;
    }

    private void Update()
    {
        
    }
}
