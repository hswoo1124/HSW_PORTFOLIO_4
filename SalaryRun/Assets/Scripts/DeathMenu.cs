using UnityEngine;
using System.Collections;

public class DeathMenu : MonoBehaviour {
    public AudioSource click;

    public string menuLevel;
    public string PlayGameLevel;

    public void RestartGame()
    {
        click.Play();
        Application.LoadLevel(PlayGameLevel);
    }

    public void QuitMenu()
    {
        click.Play();
        Application.LoadLevel(menuLevel);
    }
}
