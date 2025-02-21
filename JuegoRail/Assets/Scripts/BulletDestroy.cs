using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour
{
    public GameObject bulletHit;
    public Transform bullet;

    
    private void OnCollisionEnter(Collision collision)
    {
        
        Destroy(this.gameObject);
        Instantiate(bulletHit, bullet.transform.position, bullet.transform.rotation);
    }
}
