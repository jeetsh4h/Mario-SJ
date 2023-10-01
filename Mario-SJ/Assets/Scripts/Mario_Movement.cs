using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Mario_Movement : MonoBehaviour
{
    private float horizontal; // horizontal input
    private float moveSpeed = 8f; 
    private float jump = 16f;
    private bool IsFacingRight = true;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * moveSpeed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * moveSpeed;
        }
    }
}
