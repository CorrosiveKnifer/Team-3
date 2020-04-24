using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 2;

    private Vector3 moveVelocity;
    //public Rigidbody rig;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveInput;
        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.y = 0;
        moveInput.z = Input.GetAxis("Vertical");
        //Input.GetAxis("Horizontal")
        //transform.Translate();
        moveVelocity = moveInput * speed;
    }

    private void FixedUpdate()
    {
        transform.position = transform.position + moveVelocity * Time.deltaTime;
    }
}
