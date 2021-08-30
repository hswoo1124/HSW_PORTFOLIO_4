using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

    public string PlayGameLevel;
    public string HowToLevel;
    public AudioSource clicks;



    public void PlayGame()
    {
        clicks.Play();
        Application.LoadLevel(PlayGameLevel);
    }

    public void QuitGame()
    {
        clicks.Play();
        Application.Quit();
    }
    public void HowToP()
    {
        clicks.Play();
        Application.LoadLevel(HowToLevel);
    }

}
