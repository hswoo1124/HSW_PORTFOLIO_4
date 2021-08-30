using UnityEngine;
using System.Collections;
using System;

public class TrapBirdDamage : MonoBehaviour
{
  
    public int scoreToGive;

    private Health theHealth;

    public Collider2D birdCollider;

    // Use this for initialization
    void Start()
    {
        theHealth = FindObjectOfType<Health>();

        birdCollider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (theHealth.Min_Health < 0)
        {
            theHealth.Min_Health = 0f;
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
           
            theHealth.Min_Health = theHealth.Min_Health - 12.0f;
            //gameObject.SetActive(false);
        }
    }
}


