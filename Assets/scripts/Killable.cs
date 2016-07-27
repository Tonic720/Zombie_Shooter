using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Killable : MonoBehaviour {
	public int maxHealth = 100;
	public int currentHealth = 0;
	public Text restart;

	public bool killed;
	//public Text healthUi;

	// Use this for initialization
	void Start () {
		// everyone starts at 100% health at the start
		killed = false;
		currentHealth = maxHealth;

	}
	void Update(){
		
	}

	// notice we made this a public function; thats so death trigger can use it

	public void Hurt(bool hit){

		if (hit == true) {
			//Destroy (gameObject);
			SceneManager.LoadScene(1);


		}
		//currentHealth -= damage;
		//currentHealth = Mathf.Clamp (currentHealth, 0, maxHealth);
	}


}
