using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHit : MonoBehaviour {

	public GameManagement gm;

	void OnTriggerEnter2D(Collider2D col) { 
		Dead ();
	}

	void Dead(){
		gm.AllTreeStop ();
		gm.isDead = true;
		Destroy (gameObject);
	}
}
