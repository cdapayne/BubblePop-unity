using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class news : MonoBehaviour {

    public GameObject[] ok;
    public float spawnMin = 1f; //spawn aleatoriamente entre 1s
    public float spawnMax = 2f; //e 2s
                                // Use this for initialization
    void Start () {
        Spawn();
    }
	
	// Update is called once per frame
	void Update () {
        Spawn();
    }

    void Spawn()
    {
      
            Instantiate(ok[Random.Range(0, ok.Length)], transform.position, Quaternion.identity);
            Invoke("Spawn", Random.Range(spawnMin, spawnMax));
     
      
    }
}
