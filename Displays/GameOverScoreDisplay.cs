using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOverScoreDisplay : MonoBehaviour {

	ScoreAbsorber scoreAbsorber;
		
	// Use this for initialization
	void Start () {
		Text scoreText = GetComponent<Text> ();
		scoreAbsorber = FindObjectOfType<ScoreAbsorber> ();
		scoreText.text = "Score: " + scoreAbsorber.score;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
