using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {

	Vector2 moveVector;
	Rigidbody2D myRigidBody;
	public float playerSpeed = 10f;
    public Transform shootPoint;
    public GameObject bullet;

    
    float shootInterval = 0;
    public float bulletSpeed = 200f;
    public float bulletTimer;


    // Use this for initialization
    void Start () {
		myRigidBody = GetComponent<Rigidbody2D> ();

	}

	// Update is called once per frame
	void Update () {
		float horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");

		moveVector = new Vector2 (horizontal, vertical);

		if (moveVector.magnitude > 1f) {
			//normalization
			//moveVector /= moveVector.magnitude; //manual way
			moveVector = moveVector.normalized; // better way of normalization
		}
		// Sceen to world point
		Vector3 cursorPosInWorld = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		Vector3 lookDirection = cursorPosInWorld - transform.position;

		// set Z of the world point to 0;
		cursorPosInWorld.z = 0f;
		lookDirection.z = 0f;

		transform.up = lookDirection;

        if (Input.GetMouseButtonDown(0)) {
            shootBullet();
        }



			
		}
	void FixedUpdate(){
		

		myRigidBody.velocity = moveVector * playerSpeed;




	}

    void shootBullet() {
       bulletTimer += Time.deltaTime;

        if (bulletTimer >= shootInterval)
        {
            
            Vector3 cursorPosInWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 lookDirection = cursorPosInWorld - transform.position;
            lookDirection.Normalize();


            
                GameObject bulletClone;
               bulletClone = Instantiate(bullet,shootPoint.transform.position, shootPoint.transform.rotation) as GameObject;
               bulletClone.GetComponent<Rigidbody2D>().velocity = lookDirection * bulletSpeed;

                bulletTimer = 0;
            }
           
        }

    }


