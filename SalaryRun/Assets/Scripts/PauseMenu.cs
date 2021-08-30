using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {

    public string menuLevel;
    public string PlayGameLevel;
    public string ContinueGame;
    public GameObject PauseMenu1;
    public AudioSource phone;
    public AudioSource button;

    public void ContinueGame2()
    {
        phone.Play();
        PauseMenu1.SetActive(false);
        Time.timeScale = 1.0f;

        }
  
   
    public void RestartGame()
    {
        button.Play();
        Time.timeScale = 1.0f;
        Application.LoadLevel(PlayGameLevel);
    }

    public void QuitMenu() {
        button.Play();
        Time.timeScale = 1.0f;
        Application.LoadLevel(menuLevel);
    }
   

}
