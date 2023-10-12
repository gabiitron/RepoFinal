using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DOIWANNAKNOWWWW : MonoBehaviour
    
{
   
    public float movementSpeed;

    private float horitzontalInput;

    private Rigidbody2D rb;
    private float horizontalInput;

    void Start()
    {
        this.rb = this.GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        Vector2 velocity = this.rb.velocity;
    velocity.x = this.horizontalInput = this.movementSpeed = Time.deltaTime;
        this.rb.velocity = velocity;
        }
}