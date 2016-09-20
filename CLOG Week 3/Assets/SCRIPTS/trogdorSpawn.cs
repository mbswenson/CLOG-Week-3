using UnityEngine;
using System.Collections;

public class trogdorSpawn : MonoBehaviour {
	
	public GameObject burninator;

	void Update () {
		//if (Input.GetKey (KeyCode.T)) {
			//Debug.Log ("TROGDOR!!! (ROCK MUSIC PLAYS INTENSELY)");
			//spawns THE BURNINATOR (trOGDOR!!!)
			//Instantiate (burninator, transform.position, transform.rotation);

		if (Input.GetKey (KeyCode.Space)) {
			GameObject temp = Instantiate (burninator, transform.position, transform.rotation) as GameObject;
			temp.GetComponent<Rigidbody> ().AddForce (Vector3.right * 100);
			}
		}
	}