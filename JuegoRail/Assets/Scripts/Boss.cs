using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public int HP = 100;
    private void OnCollisionEnter(Collision collision)
    {
            HP -= 1;
            if (HP <= 0)
            {
                Destroy(this.gameObject);
            }
    }
}
