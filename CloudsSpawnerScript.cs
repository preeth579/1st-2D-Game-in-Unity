using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudsSpawnerScript : MonoBehaviour
{
    public GameObject clouds;
    public float spawnRate = 2;
    public float timer = 0;
    public float heightOfset = 10;

    // Start is called before the first frame update
    void Start()
    {
        spawnClouds();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnClouds();
            timer = 0;
        }
    }
    void spawnClouds()
    {
        float lowestPoint = 0;
        float highestPoint = 0;
        Instantiate(clouds, new Vector3(Random.Range(lowestPoint, highestPoint), transform.position.y, 0), transform.rotation);
    }
}
