using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHit : MonoBehaviour {

	public GameManagement gm;

	void OnCollisionEnter2D(Collision2D coll) {
		Dead ();
	}

	void Dead(){
		gm.AllTreeStop ();
		gm.isDead = true;
		Destroy (gameObject);
	}
}
