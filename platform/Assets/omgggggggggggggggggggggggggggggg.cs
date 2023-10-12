using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class omgggggggggggggggggggggggggggggg : MonoBehaviour
{
    Vector2 moveInput;
    Rigidbody2D myRigidBody;

    [SerializeField] float moveSpeed = 0.01f;

    [SerializeField] float runSpeed = 10f;


     void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        float moveAmount = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        transform.Translate(0, moveAmount, 0);
        
        Run();
    }
    
    void Run()
    {
        Vector2 playerVelocity = new Vector2(moveInput.x * runSpeed, myRigidBody.velocity.y);
        myRigidBody.velocity = playerVelocity;
       
    }

}
