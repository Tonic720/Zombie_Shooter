using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {

    void OnTriggerStay2D(Collider2D coll)
    {

        if (coll.isTrigger != true)
        {

            if (coll.CompareTag("Enemy"))
            {

                Destroy(gameObject);
            }
			if (coll.CompareTag("Wall"))
			{

				Destroy(gameObject);
			}


        }

    }
}
