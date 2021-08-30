using UnityEngine;
using System.Collections;

public class PlatformGenerator : MonoBehaviour
{

    public GameObject thePlatform;
    public Transform generationPoint;
    public float distanceBetween;

    private float platformWidth;
    private float[] platformWidths;

    public float distanceBetweenMin;
    public float distanceBetweenMax;

    private ObjectPooler[] theObjectPools;

    private float minHeight;
    public Transform maxHeightPoint;
    private float maxHeight;
    public float maxHeightChange;
    private float heightChange;

    private CoinGenerator theCoinGenerator;
    public float randomCoinThreshold;

    public float randomTrapThreshold;
    public float randomTrapBirdThreshold;
    public float randomTrapShitThreshold;
    public float randomTrapTriThreshold;
    public float randomTrapBird2Threshold;
    public ObjectPooler TrapPool;
    public ObjectPooler TrapBirdPool;
    public ObjectPooler TrapShitPool;
    public ObjectPooler TrapTriPool;
    public ObjectPooler TrapBird2Pool;
    private float limit;

    public GameObject[] thePlatforms;
    private int platformSelector;


    // Use this for initialization
    void Start()
    {


        platformWidths = new float[thePlatforms.Length];

        for (int i = 0; i < thePlatforms.Length; i++)
        {
            platformWidths[i] = thePlatforms[i].GetComponent<BoxCollider2D>().size.x;
        }
        theCoinGenerator = FindObjectOfType<CoinGenerator>();

        minHeight = transform.position.y;
        maxHeight = maxHeightPoint.position.y;
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.x < generationPoint.position.x)
        {
            distanceBetween = Random.Range(distanceBetweenMin, distanceBetweenMax);
            
            platformSelector = Random.Range(0, thePlatforms.Length);

            transform.position = new Vector3(transform.position.x + platformWidths[platformSelector]  + distanceBetween, heightChange, transform.position.z);

            heightChange = transform.position.y + Random.Range(-maxHeightChange, maxHeightChange);

            if(heightChange > maxHeight)
            {
                heightChange = maxHeight;
            }
            else if(heightChange < minHeight)
            {
                heightChange = minHeight;
            }


            Instantiate(thePlatforms[platformSelector], transform.position, transform.rotation);


            if (Random.Range(0f, 100f) < randomCoinThreshold)
            {
                theCoinGenerator.SpawnCoins(new Vector3(transform.position.x, transform.position.y + 5f, transform.position.z));
            }

            if (Random.Range(0f, 100f) < randomTrapThreshold)
            {
                GameObject newTrap = TrapPool.GetPooledObject();
                float trapnumber = Random.Range(0, 6);

                if (trapnumber == 1)
                {
                    newTrap.transform.position = transform.position + new Vector3(0.5f, 0.25f, 0f);
                    newTrap.transform.rotation = transform.rotation;
                    newTrap.SetActive(true);
                }
                if (trapnumber == 2)
                {
                    newTrap.transform.position = transform.position + new Vector3(1.5f, 0.25f, 0f);
                    newTrap.transform.rotation = transform.rotation;
                    newTrap.SetActive(true);
                }
                if (trapnumber == 3)
                {
                    newTrap.transform.position = transform.position + new Vector3(3f, 0.25f, 0f);
                    newTrap.transform.rotation = transform.rotation;
                    newTrap.SetActive(true);
                }
                if (trapnumber == 4)
                {
                    newTrap.transform.position = transform.position + new Vector3(4.5f, 0.25f, 0f);
                    newTrap.transform.rotation = transform.rotation;
                    newTrap.SetActive(true);
                }
                if (trapnumber == 5)
                {
                    newTrap.transform.position = transform.position + new Vector3(6f, 0.25f, 0f);
                    newTrap.transform.rotation = transform.rotation;
                    newTrap.SetActive(true);
                }
            }

            if (Random.Range(0f, 100f) < randomTrapBirdThreshold)
            {
                GameObject newBirdTrap = TrapBirdPool.GetPooledObject();

                Vector3 trapPosition = new Vector3(3f, 3f, 0f);

                newBirdTrap.transform.position = transform.position + trapPosition;
                newBirdTrap.transform.rotation = transform.rotation;
                newBirdTrap.SetActive(true);

            }

            if (Random.Range(0f, 100f) < randomTrapShitThreshold)
            {
                GameObject newShitTrap = TrapShitPool.GetPooledObject();

                float trapnumber = Random.Range(0, 6);

                if (trapnumber == 1)
                {
                    newShitTrap.transform.position = transform.position + new Vector3(2f, 10f, 0f);
                    newShitTrap.transform.rotation = transform.rotation;
                    newShitTrap.SetActive(true);
                }
                if (trapnumber == 2)
                {
                    newShitTrap.transform.position = transform.position + new Vector3(3.5f, 10f, 0f);
                    newShitTrap.transform.rotation = transform.rotation;
                    newShitTrap.SetActive(true);
                }
                if (trapnumber == 3)
                {
                    newShitTrap.transform.position = transform.position + new Vector3(4f, 10f, 0f);
                    newShitTrap.transform.rotation = transform.rotation;
                    newShitTrap.SetActive(true);
                }
                if (trapnumber == 4)
                {
                    newShitTrap.transform.position = transform.position + new Vector3(5f, 10f, 0f);
                    newShitTrap.transform.rotation = transform.rotation;
                    newShitTrap.SetActive(true);
                }
                if (trapnumber == 5)
                {
                    newShitTrap.transform.position = transform.position + new Vector3(5.5f, 10f, 0f);
                    newShitTrap.transform.rotation = transform.rotation;
                    newShitTrap.SetActive(true);
                }


            }

            if (Random.Range(0f, 100f) < randomTrapTriThreshold)
            {
                GameObject newTriTrap = TrapTriPool.GetPooledObject();

                float trapnumber = Random.Range(0, 6);

                if (trapnumber == 1)
                {
                    newTriTrap.transform.position = transform.position + new Vector3(1.5f, 0.5f, 0f);
                    newTriTrap.transform.rotation = transform.rotation;
                    newTriTrap.SetActive(true);
                }
                if (trapnumber == 2)
                {
                    newTriTrap.transform.position = transform.position + new Vector3(2.5f, 0.5f, 0f);
                    newTriTrap.transform.rotation = transform.rotation;
                    newTriTrap.SetActive(true);
                }
                if (trapnumber == 3)
                {
                    newTriTrap.transform.position = transform.position + new Vector3(4f, 0.5f, 0f);
                    newTriTrap.transform.rotation = transform.rotation;
                    newTriTrap.SetActive(true);
                }
                if (trapnumber == 4)
                {
                    newTriTrap.transform.position = transform.position + new Vector3(4.8f, 0.5f, 0f);
                    newTriTrap.transform.rotation = transform.rotation;
                    newTriTrap.SetActive(true);
                }
                if (trapnumber == 5)
                {
                    newTriTrap.transform.position = transform.position + new Vector3(5.5f, 0.5f, 0f);
                    newTriTrap.transform.rotation = transform.rotation;
                    newTriTrap.SetActive(true);
                }

            }

            if (Random.Range(0f, 100f) < randomTrapBird2Threshold)
            {
                GameObject newBird2Trap = TrapBird2Pool.GetPooledObject();

                float trapnumber = Random.Range(0, 6);

                if (trapnumber == 1)
                {
                    newBird2Trap.transform.position = transform.position + new Vector3(1.5f, 10.0f, 0f);
                    newBird2Trap.transform.rotation = transform.rotation;
                    newBird2Trap.SetActive(true);
                }
                if (trapnumber == 2)
                {
                    newBird2Trap.transform.position = transform.position + new Vector3(3.5f, 5.0f, 0f);
                    newBird2Trap.transform.rotation = transform.rotation;
                    newBird2Trap.SetActive(true);
                }
                if (trapnumber == 3)
                {
                    newBird2Trap.transform.position = transform.position + new Vector3(5.0f, 4.0f, 0f);
                    newBird2Trap.transform.rotation = transform.rotation;
                    newBird2Trap.SetActive(true);
                }
                if (trapnumber == 4)
                {
                    newBird2Trap.transform.position = transform.position + new Vector3(6.0f, 3.0f, 0f);
                    newBird2Trap.transform.rotation = transform.rotation;
                    newBird2Trap.SetActive(true);
                }
                if (trapnumber == 5)
                {
                    newBird2Trap.transform.position = transform.position + new Vector3(5.5f, 8.0f, 0f);
                    newBird2Trap.transform.rotation = transform.rotation;
                    newBird2Trap.SetActive(true);
                }

            }
        }
    }
}