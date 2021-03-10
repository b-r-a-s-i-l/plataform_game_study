using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public int health;
    public Animator anim;
    public float jumpForce; // para controlar a forçã do trampolim
    public bool isDown;
    public GameObject effect, box;

    void Start()
    { 
        if (isDown) jumpForce *= -1f;
    }

    void Update()
    {
        if (health <= 0)
        {
            Instantiate(effect, transform.position, transform.rotation);
            Destroy(transform.parent.gameObject); // destroi o objeto pai
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            anim.SetBool("hit", true);
            health--;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        anim.SetBool("hit", false);
    }
}
