using UnityEngine;
using System.Collections;

public class ScoreCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision) {
		GlobalScoreKeeper scoreKeeper = FindObjectOfType<GlobalScoreKeeper> ();
		scoreKeeper.IncrementScore ();
	}
}
