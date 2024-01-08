using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class Temp_GameObject : MonoBehaviour
{
    public int hp = 30;
    public Vector3 pos = Vector3.zero;


    void Start()
    {
        hp = 50;

        pos = new Vector3(20, 20, 20);
        transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            hp -= 1;


        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0.0f, 1.0f * Time.deltaTime, 0.0f);
        }
    }
    
}
