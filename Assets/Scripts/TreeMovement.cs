using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeMovement : MonoBehaviour {

	public float treeSpeed;
	private Rigidbody2D rigi;

	// Use this for initialization
	void Start () {
		rigi = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		rigi.velocity = new Vector2 (-1 * treeSpeed,0);

	}
}
