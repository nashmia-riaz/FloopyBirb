using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarSpawner : MonoBehaviour
{
    public GameObject pillarPrefab;

    public Transform spawnPoint;

    float timer, spawnTime;

    public float YMin, YMax;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        spawnTime = 3;
    }

    // Update is called once per frame
    void Update()
    {
        //incrementing our timer
        timer += Time.deltaTime;

        //execute code once timer runs out
        if(timer > spawnTime)
        {
            //resets our timer
            timer = 0;

            float randomYPosition = Random.Range(YMin, YMax);

            Vector3 pillarPosition = spawnPoint.position + new Vector3(0, randomYPosition, 0);

            //creating pillars
            Instantiate(pillarPrefab, pillarPosition, pillarPrefab.transform.rotation);
        }
    }
}
