using System.Collections;
using System.Collections.Generic;

using UnityEditor;

using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    //  void Start()
    //{

    //  }

    public Vector2 speed = new Vector2(50, 50);

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        Vector2 movement = new Vector3(speed.x * inputX, speed.y * inputY);

        movement *= Time.deltaTime;

        transform.Translate(movement);

    }
}
