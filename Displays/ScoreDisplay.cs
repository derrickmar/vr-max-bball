using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {

	Text text;
	GlobalScoreKeeper scoreKeeper;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
		scoreKeeper = FindObjectOfType<GlobalScoreKeeper> ();
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "Score: " + scoreKeeper.score;
	}
}
