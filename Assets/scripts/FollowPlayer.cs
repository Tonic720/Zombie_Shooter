using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {
	// to move object B pos - oject A pos
	//public Transform destination;
	GameObject player;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		//player.transform.position;
	

	}

	// Update is called once per frame
	void Update () {
		// stopping distance
		if (Vector3.Distance (transform.position,player.transform.position) > 0.25f) {
			// use delta time to make framerate independent
			transform.position += Vector3.Normalize (player.transform.position - transform.position) * Time.deltaTime;
		}

	}
	void OnDrawGizmos(){
		// will draw a line inside scene view
		Gizmos.DrawLine (transform.position, player.transform.position);
	}
    void OnTriggerEnter2D(Collider2D coll)
    {

            if (coll.CompareTag("Bullet"))
            {
                
                Destroy(gameObject);
            }



    }
}
