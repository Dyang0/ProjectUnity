using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CollisionDetection : MonoBehaviour
{

    public int health = 100; // find out how to optimize this health system. Find out what type of gun it is without having to write manually
    private Weapon gun; 


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject); //deletes bullet object
            //loseHealth("pistol");
        }
    }

  //  void loseHealth(string w) //lowers the health based on weapon damage
   // {
      // gun.weaponPick(w);
      // health -= gun.weaponDamage; 

   // }

    // Start is called before the first frame update
    void Start() //hi

    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(health);
    }
}
