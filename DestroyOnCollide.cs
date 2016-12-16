using UnityEngine;
using System.Collections;

public class DestroyOnCollide : MonoBehaviour {

	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag == "ground") {
			Destroy (this.gameObject);
		}
	}
}
