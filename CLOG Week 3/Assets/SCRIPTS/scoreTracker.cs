using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scoreTracker : MonoBehaviour {

	int score = 0;
	Text scoreText;

	// Use this for initialization
	void Start () {
		scoreText = GetComponent<Text>();
		scoreText.text = "SCORE - " + score;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void addScore(int pointsToAdd) {
		score += pointsToAdd;
		scoreText.text = "SCORE - " + score;
	}
}
