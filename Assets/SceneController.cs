using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour {

    public Track[] prefabTracks;
    List<Track> tracks = new List<Track>();

	void Start () {
        SpawnSomeTrack();
	}

	void Update () {
        for(int i = tracks.Count - 1; i >= 0; i--)
        {
            if(tracks[i].isDead)
            {
                Destroy(tracks[i].gameObject);
                tracks.RemoveAt(i);
            }
        }

        if (tracks.Count < 5) SpawnSomeTrack();
        
	}

    void SpawnSomeTrack()
    {
        while (tracks.Count < 5)
        {

            Vector3 ptOut = Vector3.zero;
            if(tracks.Count > 0) ptOut = tracks[tracks.Count - 1].pointOut.position;


            Track prefab = prefabTracks[ Random.Range(0, prefabTracks.Length) ]; // random prefab!!!1


            Vector3 ptIn = prefab.pointIn.position;
            Vector3 pos = (prefab.transform.position - ptIn) + ptOut;

            Track newTrack = Instantiate(prefab, pos, Quaternion.identity);
            tracks.Add(newTrack);
        }
    }

}
