using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //This will destory wall itself
        //Destroy(gameObject);
        //Debug.Log("Collision with the wall");
        //This will destory the object which collides with the gameobject
        if(collision.gameObject.tag != "Player")
        {
            Destroy(collision.gameObject);
        }
        
    }

}
