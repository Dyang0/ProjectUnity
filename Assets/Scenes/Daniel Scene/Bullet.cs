using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public int damage = 40;
    // Start is called before the first frame update
    void Start()
    {

        Vector3 vel = rb.velocity;
        vel.z = 0f;
        vel.x = 0f;
        vel.y = 0f;
        rb.velocity = vel;
        

        rb.velocity = transform.right * speed ; // * Time.deltaTime; //shoots the bullet in the direction you're facing
        vel.y = 0f;
        vel.z = 0f;
        vel.x = 0f;
    }

    /*private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>(); //gets the info of the enemy

        if(enemy != null) //an enemy takes damage respectively if it the enemy is real
        {
            enemy.TakeDamage(damage);
        }

        //Debug.Log(hitInfo.name);  
        Destroy(gameObject);
    }*/


}
