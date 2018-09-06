using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Track : MonoBehaviour {

    public Transform pointIn;
    public Transform pointOut;

    public Transform[] wallSpawnPoints;

    public GameObject prefabWall;
    public float speed = 10;

    [HideInInspector] public bool isDead = false;

    void Start()
    {
        if (wallSpawnPoints.Length == 0) return;
        if (!prefabWall) return;

        // Get a random position:
        int randIndex = Random.Range(0, wallSpawnPoints.Length);
        Vector3 spawnPos = wallSpawnPoints[randIndex].position;

        // Spawn a wall, parent it to this chunk of track:
        Instantiate(prefabWall, spawnPos, Quaternion.identity, transform);
    }

    void Update()
    {
        transform.position += new Vector3(0, 0, -speed) * Time.deltaTime;

        if(pointOut.position.z < -5)
        {
            isDead = true;
        }
    }


}
