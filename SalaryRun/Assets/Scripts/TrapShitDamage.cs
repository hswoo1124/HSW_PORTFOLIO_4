using UnityEngine;
using System.Collections;

public class TrapShitDamage : MonoBehaviour {

    private Health theHealth;
  
    // Use this for initialization
    void Start () {
      

        theHealth = FindObjectOfType<Health>();
    }
	
	// Update is called once per frame
	void Update () {
        if (theHealth.Min_Health < 0)
        {
            theHealth.Min_Health = 0f;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
          
            theHealth.Min_Health = theHealth.Min_Health - 5.0f;
            //gameObject.SetActive(false);

        }
    }
}
