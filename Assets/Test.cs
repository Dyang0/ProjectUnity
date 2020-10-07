using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("o"))
        {
            SceneManager.LoadScene("Scene2"); ///Hi This is Daniel
        } //This is anthony
    }
}
