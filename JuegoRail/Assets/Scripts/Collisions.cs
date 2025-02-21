using UnityEngine;

public class Collisions : MonoBehaviour
{
    public int HP = 5;
    public GameObject PlayerDa�o;
    public GameObject EnemyDeath;
    public Transform player;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Instantiate(PlayerDa�o, player.transform.position, player.transform.rotation);

            Destroy(this.gameObject);
        }
        else
        {
            HP -= 1;
            if (HP <= 0)
            {
                Destroy(this.gameObject);
                Instantiate(EnemyDeath, player.transform.position, player.transform.rotation);

            }
        }

    }
}
