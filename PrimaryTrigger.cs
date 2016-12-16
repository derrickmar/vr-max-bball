using UnityEngine;
using System.Collections;

public class PrimaryTrigger : MonoBehaviour {
	private SecondaryTrigger secondaryTrigger;

	// collider is the other collider entering the trigger. In this case
	// the basketball's collider
	void OnTriggerEnter(Collider collider) {
		secondaryTrigger = GetComponentInChildren<SecondaryTrigger> ();
		secondaryTrigger.ExpectCollider(collider);
	}
}
