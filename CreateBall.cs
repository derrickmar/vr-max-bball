using UnityEngine;
using System.Collections;

public class CreateBall : MonoBehaviour {

	public GameObject ballPrefab;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		GameObject instance;

		if (Input.GetKeyDown (KeyCode.Space)) {
			instance = Instantiate (ballPrefab);
			Rigidbody rb = instance.GetComponent<Rigidbody> ();
			rb.velocity = Vector3.left * 10.0f;
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			instance = Instantiate (ballPrefab);
			Rigidbody rb = instance.GetComponent<Rigidbody> ();
			rb.velocity = Vector3.right * 5.0f;
		}
	}
}
