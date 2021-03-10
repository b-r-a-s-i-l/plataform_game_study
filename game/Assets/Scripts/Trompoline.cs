using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trompoline : MonoBehaviour
{
    private Animator anim;
    public float jumpForce; // para controlar a forçã do trampolim

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            anim.SetTrigger("jump");
        }
    }
}
