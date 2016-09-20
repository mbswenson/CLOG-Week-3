using UnityEngine;
using System.Collections;

public class enemyHitDetection : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	void OnTriggerEnter(Collider other) {
		Destroy (other.gameObject); //destroy bullet
		GameObject scoreH = GameObject.Find("ScoreHolder");
		scoreH.GetComponent<scoreTracker> ().addScore (10);
		//get score object and add score
		Destroy (gameObject); // destroy self
	}
}
