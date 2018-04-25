using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour {

	public bool isDead = false;
	public GameObject enemy;
	public float waitingTime = 3;

	public GameObject deadImage;

	IEnumerator Start(){
		deadImage.SetActive (false);
		while (!isDead) {
			Instantiate (enemy, new Vector2 (10, Random.Range (-1.45f, 1.54f)), Quaternion.identity);
			yield return new WaitForSeconds (waitingTime);
		}
	}
	public void AllTreeStop(){
		deadImage.SetActive (true);
		GameObject[] go = GameObject.FindGameObjectsWithTag ("Tree");
		foreach(GameObject ele in go){
			ele.GetComponent<Rigidbody2D> ().bodyType = RigidbodyType2D.Static;
			ele.GetComponent<TreeMovement> ().enabled = false;
		}
	}
	public void Restart(){
		deadImage.SetActive (false);
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}
}
