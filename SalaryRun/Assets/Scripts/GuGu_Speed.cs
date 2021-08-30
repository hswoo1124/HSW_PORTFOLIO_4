using UnityEngine;
using System.Collections;

public class GuGu_Speed : MonoBehaviour {

    public float speedX = 2.0f;
    public float speedY = 2.0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x - Time.deltaTime*speedX, transform.position.y - Time.deltaTime*speedY, transform.position.z);

    }
}