using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bubble : MonoBehaviour {

    public GameObject gx;
	// Use this for initialization
	void Start () {
        for (int i = 0; i < 10; i++)
        {
            Instantiate(gx, new Vector3(i * 2.0F, 0, 0), Quaternion.identity);
        }
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, 5f, 0);
	}
}
