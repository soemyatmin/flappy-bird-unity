using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerJump : MonoBehaviour {

	public float jumpSpeed = 800;
	private Rigidbody2D rb;
	public float MaxJumpSpeed = 15;
	float currentJumpSpeed;

	public Text Score;

	int scoreTemp;

	void Start()
	{
		scoreTemp = (int)Time.time;
		rb = GetComponent<Rigidbody2D>();
	}

	void Update () {
		if(Input.GetMouseButtonDown(0)){
			rb.AddForce (new Vector2(0,jumpSpeed));
		}
		currentJumpSpeed = Mathf.Clamp(rb.velocity.y, -MaxJumpSpeed, MaxJumpSpeed);
		rb.velocity = new Vector2 (0,currentJumpSpeed);
		Score.text = "Score: "+((int)Time.time - scoreTemp);
	}
}
