using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    [Header("Player Movement")]
    [Range(0.0f, 200.0f)]
    public float horizontalForce;
    [Range(0.0f, 1.0f)]
    public float velocity_Decay;
    public Bounds bounds;

    public Rigidbody2D playerShip_RigidyBody2D; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
        CheckBounds();
    }

    private void Move()
    {
        var x = Input.GetAxisRaw("Horizontal");

        playerShip_RigidyBody2D.AddForce(new Vector2(x * horizontalForce, 0.0f));

        playerShip_RigidyBody2D.velocity *= (1.0f - velocity_Decay);
    }

    private void CheckBounds()
    {
        if(transform.position.x < bounds.min)
        {
            transform.position = new Vector2(bounds.min, transform.position.y);
        }

        if (transform.position.x > bounds.max)
        {
            transform.position = new Vector2(bounds.max, transform.position.y);
        }
    }
}
