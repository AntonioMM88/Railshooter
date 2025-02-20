using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHP : MonoBehaviour
{
    public int HP = 100;
    public int MaxHP = 100;

    // Update is called once per frame
    void Update()
    {
        if (HP > MaxHP)
        {
            HP = MaxHP;
        }

        if(HP <= 0)
        {
            
            Cursor.visible = true;
            Time.timeScale = 0;
            Destroy(this.gameObject);
            
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            HP -= 20;

        }

        if (collision.gameObject.tag == "HP")
        {
            HP += 20;
        }
    }
    
}
