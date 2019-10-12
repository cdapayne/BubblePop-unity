using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Splash : MonoBehaviour {
    
    public Button yourButton;
    public float movementSpeed = 10;
    public GameObject ball;
    public float spawnTime = 3f;
    public Rigidbody projectile;
    // Use this for initialization
    void Start () {

        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

        InvokeRepeating("SpawnBall", spawnTime, spawnTime);
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);

        // Instantiate the projectile at the position and rotation of this transform
        
    }
    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
        yourButton.gameObject.SetActive(false);
    }

    void SpawnBall()
    {
        Debug.Log("wow");
        var newBall = GameObject.Instantiate(ball);
        newBall.transform.position = new Vector3(ball.transform.position.x, 1.5f, 0.0f);
    }


}
