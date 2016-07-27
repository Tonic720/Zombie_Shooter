using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {

	public Text restart;


	// Use this for initialization
	void Start () {
		restart.text = "Press [R] to restart";


	}

	

	
	// Update is called once per frame
		void Update () {
		if (Input.GetKey (KeyCode.R)) {
			SceneManager.LoadScene (0);
		}
	}
		

	

}
