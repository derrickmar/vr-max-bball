using UnityEngine;
using System.Collections;

public class SphereParameters : MonoBehaviour {

	private GlobalScoreKeeper scoreKeeper;
	public string mode;

	void Start() {
		scoreKeeper = FindObjectOfType<GlobalScoreKeeper> ();
	}

	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag == "ball") {
			switch (mode) {
			case "reset":
				scoreKeeper.reset ();
				break;
			case "faster":
				scoreKeeper.changePhaseSpeed (-500);
				break;
			case "slower":
				scoreKeeper.changePhaseSpeed (500);
				break;
			}
		}
	}
}
