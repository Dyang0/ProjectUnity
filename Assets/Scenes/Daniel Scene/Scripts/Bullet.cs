using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;

    private int weaponDamage;

    public Bullet (int wD, float s)
    {
        weaponDamage = wD;
        speed = s;
    }
   
    // Start is called before the first frame update

    void Start()
    {

        
        rb.velocity = transform.right * speed ; // * Time.deltaTime; //shoots the bullet in the direction you're facing

        Destroy(gameObject, 5f); //find a better way to detext hits or not
        
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
