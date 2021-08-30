using UnityEngine;
using System.Collections;

public class HowToPlay : MonoBehaviour {


    public AudioSource click;
    public string BackLevel;
    public string NextLevel;

    public void BackMenu() {
        click.Play();

        Application.LoadLevel( BackLevel);
    }

    public void NextMenu()
    {
        click.Play();
        Application.LoadLevel(NextLevel);
    }
}
