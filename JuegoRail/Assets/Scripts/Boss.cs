using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boss : MonoBehaviour
{
    public int HP = 100;
    public GameObject BossDeath;
    public GameObject BossDeath2;
    public Transform Boos;
    private float Cont = 0;
    public GameObject turret1, turret2, turret3, turret4;

    private void OnCollisionEnter(Collision collision)
    {
            HP -= 1;
         if (HP <= 0)
         {
                
                Instantiate(BossDeath, Boos.transform.position, Boos.transform.rotation);
                Instantiate(BossDeath2, Boos.transform.position, Boos.transform.rotation);
                

            turret1.SetActive(false);
            turret2.SetActive(false);
            turret3.SetActive(false);
            turret4.SetActive(false);
            Cont = Time.deltaTime + 5;
            if (Cont >= Time.deltaTime)
            {
                SceneManager.LoadScene("Menu");
            }

         }
    }
}
