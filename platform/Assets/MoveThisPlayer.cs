using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveThisPlayer : MonoBehaviour
{
    Vector2 moveInput;
    Rigidbody2D myRigidBody;

    [SerializeField] float runSpeed = 10f;

    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Run();
    }

    private void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    void Run()
    {
        Vector2 playerVelocity = new Vector2(moveInput.x * runSpeed, myRigidBody.velocity.y);
        myRigidBody.velocity = playerVelocity;
    }
}
