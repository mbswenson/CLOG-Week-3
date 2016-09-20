using UnityEngine;
using System.Collections;

public class killOtherObject : MonoBehaviour {

	void OnTriggerExit(Collider otherThingMoving) {
		//Destroy (otherThingMoving.gameObject);
		otherThingMoving.transform.position = otherThingMoving.transform.position + Vector3.up * 40;
		otherThingMoving.gameObject.GetComponent<Rigidbody> ().velocity = Vector3.zero;
		Debug.Log("thing moving out of the box");
	}
}