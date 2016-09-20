using UnityEngine;
using System.Collections;

public class shipShoot : MonoBehaviour {

	public GameObject Bullet;
	private bool canFire = true;
	public float rateOfFire = .4f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space) && canFire == true) {
			canFire = false;
			StartCoroutine ("reload");
			GameObject temp = Instantiate (Bullet, transform.position, transform.rotation) as GameObject;
			temp.GetComponent<Rigidbody>().AddForce (temp.transform.up * 20);

			//or alternatively, temp.transform.forward
		}
	}
	IEnumerator reload() {
		yield return new WaitForSeconds (rateOfFire);
		canFire = true;
  }
}