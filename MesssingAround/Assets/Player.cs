using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * .25f;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * .25f;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * .25f;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * .25f;
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.position += Vector3.up * .25f;
        }

        if (Input.GetKey(KeyCode.E))
        {
            transform.position += Vector3.down * .25f;
        }
    }
}
