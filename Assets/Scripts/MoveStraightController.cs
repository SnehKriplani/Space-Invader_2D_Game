using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStraightController : MonoBehaviour
{
    public Vector2 velocity;
    Rigidbody2D rdbody;

    // Start is called before the first frame update
    void Start()
    {
        rdbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rdbody.velocity = velocity;
    }
}
