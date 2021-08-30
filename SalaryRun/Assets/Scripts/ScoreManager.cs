using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public GameObject BGI1;
    public GameObject BGI2;
    public GameObject BGI3;
    public GameObject BGI4;
    public GameObject BGI5;
    public GameObject BGI6;
    public AudioSource metal;
    public AudioSource stage2;
    private Health theHealth;

    public Text scoreText;

    public float scoreCount;

    public float pointsPerSecond;

    public bool scoreIncreasing;
    private float finalscore=1;

	// Use this for initialization
	void Start () {
        BGI2.SetActive(false);
        BGI3.SetActive(false);
        BGI4.SetActive(false);
        BGI5.SetActive(false);
        BGI6.SetActive(false);
        metal.Play();
        theHealth = FindObjectOfType<Health>();

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.C))
        {
            scoreCount = 13999;
            BGI1.SetActive(false);
            BGI2.SetActive(false);
            BGI3.SetActive(false);
            BGI4.SetActive(false);
        }

        if (scoreIncreasing)
        {
        scoreCount += pointsPerSecond * Time.deltaTime;
        }

        scoreText.text = "Score: " + Mathf.Round (scoreCount);

        if(scoreCount > 5000 && scoreCount < 10000)
        {
            BGI1.SetActive(false);
            BGI2.SetActive(true);
        }
        if (scoreCount >10000 && scoreCount < 14000)
        {
            BGI2.SetActive(false);
            BGI3.SetActive(true);
        }
        if (scoreCount > 14000 && scoreCount < 18500)
        {
            stage2.Play();
            BGI3.SetActive(false);
            BGI4.SetActive(true);
        }
        if (scoreCount > 18500 && scoreCount < 23000)
        {
            BGI4.SetActive(false);
            BGI5.SetActive(true);  
            metal.Stop();
           
        }
        if (scoreCount > 23000 && scoreCount < 510000)
        {
            BGI5.SetActive(false);
            BGI6.SetActive(true);
        }
        if (theHealth.Min_Health <= 0)
        {
            scoreIncreasing = false;
            finalscore = scoreCount;
            PlayerPrefs.SetFloat("Final", finalscore);
        }
    }

    public void AddScore(int pointsToAdd)
    {
        scoreCount += pointsToAdd;
    }
    
}
