using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Rigidbody projectileRigidbody;

    private void Awake()
    {
        projectileRigidbody = GetComponent<Rigidbody>();
        
    }

    private void Update()
    {
        //ObjectPooling
        if (transform.position.magnitude > 1000.0f)
        {
            Destroy(gameObject);
        }
    }

    public void Launch(Vector3 direction, float force)
    {
        projectileRigidbody.AddForce(direction * force);
    }

    private void OnCollisionEnter(Collision monster)
    {
        MonsterTakeDamage hitMonster = monster.collider.GetComponent<MonsterTakeDamage>();

        if (hitMonster != null)
        {
            hitMonster.TakeDamage(Equip.equipinstance.equipWeaponInformation.weaponAttackPower);
        }

        //ObjectPooling
        Destroy(gameObject);
    }
}
