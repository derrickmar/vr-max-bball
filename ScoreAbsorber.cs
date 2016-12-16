using UnityEngine;
using System.Collections;

public class ScoreAbsorber : MonoBehaviour {

	public int score = 0;

	// Use this for initialization
	void Start () {
		GlobalScoreKeeper oldKeeper = FindObjectOfType<GlobalScoreKeeper> ();
		if (oldKeeper) {
			score = oldKeeper.score;
			Destroy(oldKeeper.gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
