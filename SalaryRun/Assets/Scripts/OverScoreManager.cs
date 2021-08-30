using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OverScoreManager : MonoBehaviour
{

    public Text scoreTe;
    private ScoreManager final;


    // Use this for initialization
    void Start()
    {
        final = FindObjectOfType<ScoreManager>();

    }

    // Update is called once per frame
    void Update()
    {

        scoreTe.text = "Score: " + Mathf.Round(PlayerPrefs.GetFloat("Final")); 

    }
}