using UnityEngine;
using System.Collections;

// Determines actions when a basket is made
public class SecondaryTrigger : MonoBehaviour {

	public string mode;
	private GlobalScoreKeeper scoreKeeper;
	Collider expectedCollider;

	void Start() {
		scoreKeeper = FindObjectOfType<GlobalScoreKeeper> ();
	}

	void OnTriggerEnter(Collider otherCollider) {
		// If it is the same ball collider
		if (otherCollider == expectedCollider) {
			print ("MADE A BASKET");
			scoreKeeper.IncrementScore ();
			AudioSource audioSource = GetComponent<AudioSource> ();
			audioSource.Play ();
			scoreKeeper.changeSpeed (mode);
		}
	}

	public void ExpectCollider(Collider collider) {
		expectedCollider = collider;
	}
}
