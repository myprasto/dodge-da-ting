using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMaker : MonoBehaviour {

    public Transform[] boxSpawn;

    public GameObject boxPrefab;

    public float timeBetweenWaves = 0.5f;

    public float timeToSpawn = 1f;

    void Update()
    {
        if(Time.time >= timeToSpawn)
        {
            Spawner();
            timeToSpawn = Time.time + timeBetweenWaves;
        }
    }

    void Spawner () {

        int randomIndex = Random.Range(0, boxSpawn.Length);

        for (int i = 0; i < boxSpawn.Length; i++)
        {
            if (randomIndex == i)
            {
                Instantiate(boxPrefab, boxSpawn[i].position, Quaternion.identity);
            }
        }

	}
}
