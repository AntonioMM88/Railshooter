using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretShoot : MonoBehaviour
{
    public GameObject bullet;
    public float bulletSpeed;
    public Transform player;
    public float fireRate = 1f;
    public float fireRateDelta;

    private void Update()
    {

        fireRateDelta -= Time.deltaTime;
        if (fireRateDelta <= 0)
        {
            GameObject newBullet = Instantiate(bullet, transform.position, Quaternion.identity);
            newBullet.gameObject.transform.LookAt(player);
            newBullet.gameObject.GetComponent<Rigidbody>().AddForce(newBullet.transform.forward * bulletSpeed, ForceMode.VelocityChange);
            fireRateDelta = fireRate;
        }

    }
}
