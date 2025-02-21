using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHP : MonoBehaviour
{
    public int HP = 500;
    public int MaxHP = 1000;
    

    // Update is called once per frame
    void Update()
    {
        if (HP > MaxHP)
        {
            HP = MaxHP;
        }

        if(HP <= 0)
        {
            Destroy(this.gameObject);
            
                SceneManager.LoadScene("Menu");
            



        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            HP -= 70;

        }

        if (collision.gameObject.tag == "HP")
        {
            HP += 100;
        }
    }
    
}
