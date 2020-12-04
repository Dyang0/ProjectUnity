using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start() //hi

    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }
}
