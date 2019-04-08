using UnityEngine;
using System.Collections;

public class FruitThrow : MonoBehaviour {
    //attach this script to the bullet Prefab

    float lifespan = 3.0f; //how long the bullet will stay in the game scene

	// Update is called once per frame
	void Update () {
		lifespan -= Time.deltaTime;
		if(lifespan <= 0) {
			Explode();
		}
	}

	//Bullet will be directly destroyed if it collides with Zombie
	void OnCollisionEnter(Collision collision) {
		if(collision.gameObject.tag == "Cube") {
			Destroy(gameObject);
		}

        if (collision.gameObject.name == "AppleCube(Clone)")
        {
            ScoreFruit.ascore++;
        }
        else if (collision.gameObject.name == "OrangeCube(Clone)")
        {
            ScoreFruit.oscore++;
        }
        else if (collision.gameObject.name == "LemonCube(Clone)")
        {
            ScoreFruit.lscore++;
        }
    }

	//Explode function to destroy bullet
	void Explode() {
		Destroy(gameObject);
	}
}
