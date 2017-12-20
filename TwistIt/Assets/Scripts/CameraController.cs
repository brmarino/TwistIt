using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Transform player;



	// Use this for initialization
	void Start () {

        //player = GameObject.FindGameObjectsWithTag("Player");

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void LateUpdate()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, player.position.z - 3.5f);
    }
}
