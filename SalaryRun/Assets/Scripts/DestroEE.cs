using UnityEngine;
using System.Collections;

public class DestroEE : MonoBehaviour {

  public  float interval;
  
	// Use this for initialization
	void Start () {
        
        Destroy(gameObject, interval);
	}
	
	// Update is called once per frame
	void Update () {
       

    }
}
