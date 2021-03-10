using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    private SpriteRenderer spr;
    private CircleCollider2D circle;

    public GameObject collected;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        spr = GetComponent<SpriteRenderer>();
        circle = GetComponent<CircleCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            spr.enabled = false;
            circle.enabled = false;
            collected.SetActive(true);

            GameController.instance.scoreTotal += score;
            GameController.instance.UpdateScoreText();


            Destroy(gameObject, 0.3f);
        }
    }
}
