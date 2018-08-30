using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour {

    public GameObject prefabWall;
    float delayUntilSpawn = 0;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        delayUntilSpawn -= Time.deltaTime;
        if (delayUntilSpawn <= 0)
        {
            Vector3 pos = new Vector3(0, 0, 20);
            Instantiate(prefabWall, pos, Quaternion.identity);
            delayUntilSpawn = Random.Range(1, 3);
        }
	}
}
