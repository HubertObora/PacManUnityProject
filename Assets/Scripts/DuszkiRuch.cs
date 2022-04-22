using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuszkiRuch : MonoBehaviour
{
    public Rigidbody2D duch;
    float speed = 2.8f;
    private Vector2 wektor;
    float losowa;

    // Start is called before the first frame update
    void Start()
    {
        wektor = Vector2.up;
        duch.gravityScale = 0.0f;
        //duch = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Lewa"))
        {
            wektor = Vector2.left;
        }
        if (collision.CompareTag("Prawa"))
        {
            wektor = Vector2.right;
        }
        if (collision.CompareTag("Gora"))
        {
            wektor = Vector2.up;
        }
        if (collision.CompareTag("Dol"))
        {
            wektor = Vector2.down;
        }
        if (collision.CompareTag("LewaPrawa"))
        {
            losowa = Random.Range(0, 2);
            if (losowa == 0)
            {
                wektor = Vector2.left;
            }
            else
                wektor = Vector2.right;
        }
        if (collision.CompareTag("GoraDol"))
        {
            losowa = Random.Range(0, 2);
            if (losowa == 0)
            {
                wektor = Vector2.up;
            }
            else
                wektor = Vector2.down;
        }
        if (collision.CompareTag("LewaDol"))
        {
            losowa = Random.Range(0, 2);
            if (losowa == 0)
            {
                wektor = Vector2.left;
            }
            else
                wektor = Vector2.down;
        }
        if (collision.CompareTag("PrawaDol"))
        {
            losowa = Random.Range(0, 2);
            if (losowa == 0)
            {
                wektor = Vector2.right;
            }
            else
                wektor = Vector2.down;
        }
        if (collision.CompareTag("LewaGora"))
        {
            losowa = Random.Range(0, 2);
            if (losowa == 0)
            {
                wektor = Vector2.left;
            }
            else
                wektor = Vector2.up;
        }
        if (collision.CompareTag("PrawaGora"))
        {
            losowa = Random.Range(0, 2);
            if (losowa == 0)
            {
                wektor = Vector2.right;
            }
            else
                wektor = Vector2.up;
        }
        if (collision.CompareTag("LewaPrawaGora"))
        {
            losowa = Random.Range(0, 3);
            if (losowa == 0)
            {
                wektor = Vector2.left;
            }
            if (losowa == 1)
            {
                wektor = Vector2.right;
            }
            if (losowa == 2)
            {
                wektor = Vector2.up;
            }
        }
        if (collision.CompareTag("LewaPrawaDol"))
        {
            losowa = Random.Range(0, 3);
            if (losowa == 0)
            {
                wektor = Vector2.left;
            }
            if (losowa == 1)
            {
                wektor = Vector2.right;
            }
            if (losowa == 2)
            {
                wektor = Vector2.down;
            }
        }
        if (collision.CompareTag("GoraDolLewa"))
        {
            losowa = Random.Range(0, 3);
            if (losowa == 0)
            {
                wektor = Vector2.up;
            }
            if (losowa == 1)
            {
                wektor = Vector2.down;
            }
            if (losowa == 2)
            {
                wektor = Vector2.left;
            }
        }
        if (collision.CompareTag("GoraDolPrawa"))
        {
            losowa = Random.Range(0, 3);
            if (losowa == 0)
            {
                wektor = Vector2.up;
            }
            if (losowa == 1)
            {
                wektor = Vector2.down;
            }
            if (losowa == 2)
            {
                wektor = Vector2.right;
            }
        }
        if (collision.CompareTag("LewaPrawaGoraDol"))
        {
            losowa = Random.Range(0, 4);
            if (losowa == 0)
            {
                wektor = Vector2.up;
            }
            if (losowa == 1)
            {
                wektor = Vector2.down;
            }
            if (losowa == 2)
            {
                wektor = Vector2.right;
            }
            else
                wektor = Vector2.left;
        }
    }
    // Update is called once per frame
    void Update()
    {
        duch.velocity = wektor * speed;
    }
}
