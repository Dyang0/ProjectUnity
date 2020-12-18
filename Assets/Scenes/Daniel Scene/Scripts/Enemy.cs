using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;


    // Start is called before the first frame update
    void Start()
    {
        
    }
   
    // Update is called once per frame
    public void loseHealth(int bD)
    {
        health -= bD;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {

            Destroy(collision.gameObject); //deletes bullet object
            loseHealth(10);  //Make it so the bulletDamage reducces health
            //loseHealth("pistol");
        }
    }

    void Update()
    {


       Debug.Log(health); //shows enemie's health

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

   


}
