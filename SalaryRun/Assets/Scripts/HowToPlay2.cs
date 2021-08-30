using UnityEngine;
using System.Collections;

public class HowToPlay2 : MonoBehaviour {

    public AudioSource click;
    public string BackGoLevel;

    public void BackMenu()
    {
        click.Play();
        
        Application.LoadLevel(BackGoLevel);
    }

}
