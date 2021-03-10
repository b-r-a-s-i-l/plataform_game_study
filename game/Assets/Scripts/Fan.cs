using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fan : MonoBehaviour
{
    public float speed, moveTime;
    public bool dirRight;

    private float timer;

    // Update is called once per frame
    void Update()
    {
        if (dirRight)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }

        timer += Time.deltaTime; // incrementa a variável timer

        if (timer >= moveTime)
        {
            dirRight = !dirRight;
            timer = 0f;
        }

    }
}
