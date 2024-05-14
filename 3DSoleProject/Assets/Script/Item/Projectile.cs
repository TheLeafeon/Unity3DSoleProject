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
        //ObjectPooling ���� ���� ����
        if (transform.position.magnitude > 100.0f)
        {
            Destroy(gameObject);
        }
    }

    public void Launch(Vector3 direction, float force)
    {
        projectileRigidbody.AddForce(direction * force);
    }

    private void OnTriggerEnter(Collider collision)
    {
        UnityEngine.Debug.Log("��Ʈ!");
        MonsterTakeDamage hitMonster = collision.GetComponent<MonsterTakeDamage>();

        if (hitMonster != null)
        {
            hitMonster.TakeDamage(Equip.equipinstance.equipWeaponInformation.weaponAttackPower);
        }

        //ObjectPooling���� ���� ����
        Destroy(gameObject);
    }
}
