using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public Canvas canvasMenuGlowne;
    public Canvas canvasWyniki;
    public Canvas canvasPomoc;
    public static string nick;
    public AudioClip muzykaMenu;
    public Text nickText;
    public Text wynik1;
    public Text wynik2;
    public Text wynik3;
    public Text wynik4;
    public Text wynik5;
    public Text wynik6;
    public Text wynik7;
    public Text wynik8;
    public Text wynik9;
    public Text wynik10;
    public void nowaGra()
    {
        nick = nickText.text.ToString();
        SceneManager.LoadSceneAsync(1);
    }
    public void wyniki()
    {
        canvasMenuGlowne.enabled = false;
        canvasWyniki.enabled = true;
        canvasPomoc.enabled = false;
        wynik1.text = PacManRuch.wynikiString[0];
        wynik2.text = PacManRuch.wynikiString[1];
        wynik3.text = PacManRuch.wynikiString[2];
        wynik4.text = PacManRuch.wynikiString[3];
        wynik5.text = PacManRuch.wynikiString[4];
        wynik6.text = PacManRuch.wynikiString[5];
        wynik7.text = PacManRuch.wynikiString[6];
        wynik8.text = PacManRuch.wynikiString[7];
        wynik9.text = PacManRuch.wynikiString[8];
        wynik10.text = PacManRuch.wynikiString[9];

    }
    public void wrocDoMenu()
    {
        canvasMenuGlowne.enabled = true;
        canvasWyniki.enabled = false;
        canvasPomoc.enabled = false;
    }
    public void wyjscieZgry()
    {
        Application.Quit();
    }
    public void pomoc()
    {
        canvasPomoc.enabled = true;
        canvasMenuGlowne.enabled = false;
        canvasWyniki.enabled = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
