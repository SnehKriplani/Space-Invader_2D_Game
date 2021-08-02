using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionMonsterBulletController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Monster" || collision.gameObject.tag == "Bullet")
        {
            Physics2D.IgnoreCollision(collision.transform.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
        else
        {
            Destroy(gameObject);
            if (collision.gameObject.tag != "wall")
            {
                Destroy(collision.gameObject);
            }
        }
    }
}
