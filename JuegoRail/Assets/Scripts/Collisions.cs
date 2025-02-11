using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    public int HP  = 5;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
        else
        {
            HP -= 1;
            if (HP <= 0)
            {
                Destroy(this.gameObject);
            }
        }
            
    }
}
