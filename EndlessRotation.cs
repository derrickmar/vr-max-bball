using UnityEngine;
using System.Collections;

public class EndlessRotation : MonoBehaviour {

	public GameObject player;
	Quaternion currRotation;
	Camera camera;
	GameObject body;

	// Use this for initialization
	void Start () {
		currRotation = transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
		// EASY WAY
//		transform.rotation = Quaternion.Euler (0, 1, 0) * transform.rotation;

		// Storing a variable and using deltaTime
//		currRotation = currRotation * Quaternion.Euler(0, currRotation.y + Time.deltaTime, 0);
//		transform.rotation = currRotation;

		// Using mouse input
//		float rotationSpeed = 5.0f;
//		float mouseX = Input.GetAxis ("Mouse X") * rotationSpeed;
//		transform.rotation = Quaternion.Euler (0, mouseX, 0) * transform.rotation;
//
//		float mouseY = Input.GetAxis ("Mouse Y") * rotationSpeed;
//		transform.rotation = Quaternion.Euler (-mouseY, 0, 0) * transform.rotation;
	}
}
