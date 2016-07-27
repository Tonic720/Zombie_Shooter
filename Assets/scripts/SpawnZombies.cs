using UnityEngine;
using System.Collections;

public class SpawnZombies : MonoBehaviour {
	public GameObject thingToClone;


	void Start(){
		InvokeRepeating ("Spawn", 0f, 3f);



	}

	void Spawn(){
		Instantiate (thingToClone,new Vector3(transform.position.x,transform.position.y,0f),Quaternion.Euler(0f,0f,0f));
	}



//	// Update is called once per frame
//	void Update () {
//		if (Input.GetKeyDown (KeyCode.Space)) {
//			// then make a new copy of the thing at a random point
//
//
//			Instantiate (thingToClone,new Vector3(transform.position.x,transform.position.y,0f),Quaternion.Euler(0f,0f,0f));
//		}
//
//	}
}
