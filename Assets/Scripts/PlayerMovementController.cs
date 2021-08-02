using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody2D rbody;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Left right with A and D
        float h = Input.GetAxis("Horizontal");
        //Up Down with W and S
        float v = Input.GetAxis("Vertical");

        Vector2 dir = new Vector2(h, v);
        rbody.velocity = dir.normalized * speed;
        animator.SetBool("Isflyingleft", h < 0);
        animator.SetBool("IsflyingUp", v > 0);
        animator.SetBool("Isflyingright", h > 0);



    }
}
