using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField]
    private GameObject projectilePrefab;

    [SerializeField]
    private Transform ShotPoint;

    public float bulletspeed;


    public void Launch()
    {

        UnityEngine.Debug.Log("½´ÆÃ");

        Vector3 lookForward = new Vector3(ShotPoint.forward.x ,0.0f, ShotPoint.forward.z).normalized;

        GameObject projectileObject = Instantiate(projectilePrefab, ShotPoint.position, Quaternion.identity);

        Projectile projectile = projectileObject.GetComponent<Projectile>();


        projectile.Launch(lookForward, bulletspeed);
    }
}
