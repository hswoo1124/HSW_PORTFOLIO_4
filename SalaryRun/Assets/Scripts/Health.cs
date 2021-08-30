using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

    public float Max_Health = 100f;
    public float Min_Health = 0f;
    public GameObject healthbar;
    public GameObject PauseMenu2;
    public AudioSource stop;
    

    public static pickupPoints instance { get; internal set; }
    

    // Use this for initialization
    void Start()
    {
        Min_Health = Max_Health;
        InvokeRepeating("decreasehealth", 1f, 1f);
        PauseMenu2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Min_Health < 0)
        {
            Min_Health = 0f;
        }
        if (Input.GetKey(KeyCode.P))
        {
            stop.Play();
            Time.timeScale = 0.0f;
            PauseMenu2.SetActive(true);
        }
        if(Min_Health <= 0)
        {
            StartCoroutine("GameOver");
        }

        if (Min_Health > 100)
        {
            Min_Health = 100f;
        }

    }
    void decreasehealth()
    {
        Min_Health -= 2f;
        float calc_Health = Min_Health / Max_Health;
        SetHealthBar(calc_Health);
    }
    public void SetHealthBar(float myHealth)
    {
        healthbar.transform.localScale = new Vector3(myHealth, healthbar.transform.localScale.y, healthbar.transform.localScale.z);
    }

    IEnumerator GameOver()
    {
        
        yield return new WaitForSeconds(0.5f);
        Application.LoadLevel("DeathMenu");
    }
}
