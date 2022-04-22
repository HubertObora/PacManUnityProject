using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PacManRuch : MonoBehaviour
{
    Rigidbody2D pacMan;
    float speed = 3;
    private Vector2 wektor;
    private static int wynik = 0;
    public AudioClip punkt;
    public Text textWynik;
    public Text textNick;
    private static int[] wynikiInt = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public static string[] wynikiString = { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
    // Start is called before the first frame update
    void Start()
    {
        textNick.text = Menu.nick;
        pacMan = GetComponent<Rigidbody2D>();
        pacMan.gravityScale = 0.0f;
    }
    void Update()
    {
        if(Input.GetAxis("Horizontal")<0)
        {
            wektor = Vector2.left;
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            wektor = Vector2.right;
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            wektor = Vector2.down;
        }
        if (Input.GetAxis("Vertical") > 0)
        {
            wektor = Vector2.up;
        }
        pacMan.velocity = wektor * speed;
        if (pacMan.velocity.x == 0.5)
        {
            transform.position = new Vector2(Mathf.Round(transform.position.x), transform.position.y);
        }
        if (pacMan.velocity.y == 0.5)
        {
            transform.position = new Vector2(transform.position.x, Mathf.Round(transform.position.y));
        }
        transform.up = wektor;
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            KoniecGry();
        }
        if(wynik > 142)
        {
            KoniecGry();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Punkt")
        {
            Destroy(collision.gameObject);
            AudioSource.PlayClipAtPoint(punkt, transform.position);
            wynik++;
            textWynik.text = wynik.ToString();
        }
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            KoniecGry();
        }
    }
    void KoniecGry()
    {
        for (int i = 0; i<10;i++)
        {
            if (wynik > wynikiInt[i])
            {
                if (i < 10)
                {
                    wynikiInt[i] = wynikiInt[i + 1];
                    wynikiString[i] = wynikiString[i + 1] +" " +textNick.text;
                }
                wynikiInt[i] = wynik;
                wynikiString[i] = wynik +" "+textNick.text;
                break;
            }
        }
        if (wynik > 142)
        {
            SceneManager.LoadSceneAsync(2);
        }
        else
        {
            SceneManager.LoadSceneAsync(0);
        }
        wynik = 0;
    }
}
