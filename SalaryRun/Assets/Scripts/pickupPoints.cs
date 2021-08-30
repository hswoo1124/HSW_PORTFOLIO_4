using UnityEngine;
using System.Collections;
using System;

public class pickupPoints : MonoBehaviour {

    public int scoreToGive;

    private ScoreManager theScoreManager;
    private Health theHealth;
    public float interval;
  



    void Awake()
    {
        Health.instance = this;

    }

    // Use this for initialization
    void Start () {
        theScoreManager = FindObjectOfType<ScoreManager>();
        theHealth = FindObjectOfType<Health>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "Player")
        {
         
            theScoreManager.AddScore(scoreToGive);
            theHealth.Min_Health = theHealth.Min_Health + 8.0f;
            gameObject.SetActive(false);

        }
    }
  

}
