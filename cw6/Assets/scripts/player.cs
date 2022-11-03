using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if player pressed A 
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = new Vector3(-3f, 1, -0.22f);
        }
        //if player pressed D
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = new Vector3(3f, 1, -0.22f);
        }

    }
}
