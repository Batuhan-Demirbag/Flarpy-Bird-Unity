using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScirpt : MonoBehaviour
{
    public float moveSpeed = 5;  // Hareket h�z�
    public float deadpipe = -45;  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime ;
    
        if(transform.position.x < deadpipe)// x ekseni -45 gelince otamatik yoket s�rekli olu�ur ovveride olur
        {
            Debug.Log("destroy pipe");
            Destroy(gameObject);
        }
    }
}
