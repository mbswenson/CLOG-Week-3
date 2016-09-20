using UnityEngine;
using System.Collections;

public class shipControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine("wait2Seconds");
		Debug.Log ("Print 2");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator wait2Seconds(){
		Debug.Log ("Print 1");
		yield return new WaitForSeconds (5);
		Debug.Log ("Print 3");
 }
}
