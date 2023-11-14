using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myrigidbody; // Rigidbody2D initialized
    public float flapStrenght; // Zýplama kodunu elle girmemiz saðlar

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) == true)  // press space bar go up
        {
            myrigidbody.velocity = Vector2.up * flapStrenght;
        }

    }
}
