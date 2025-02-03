using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoots : MonoBehaviour
{
    private Ray ray;
    public GameObject bullet;
    public float bulletSpeed, buletDamage, bulletFireRate;
    private Vector3 hitpoint;
    public LayerMask myLayerMask;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            InvokeRepeating("bulletShoot", 0, bulletFireRate);

        }
        if (Input.GetMouseButtonUp(0))
        {
            CancelInvoke("bulletShoot");

        }
    }

    private void bulletShoot()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        Physics.Raycast(ray, out hit, Mathf.Infinity, myLayerMask);

        hitpoint = hit.point;
        GameObject newBullet = Instantiate(bullet,transform.position, Quaternion.identity);
        Vector3 BulletDirection = hitpoint - transform.position;
        newBullet.gameObject.transform.LookAt(hitpoint);
        newBullet.gameObject.GetComponent<Rigidbody>().AddForce(newBullet.transform.forward * bulletSpeed, ForceMode.VelocityChange);
    }
}
