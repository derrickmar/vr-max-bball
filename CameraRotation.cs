using UnityEngine;
using System.Collections;

public class CameraRotation : MonoBehaviour {
	Camera camera;

	// Use this for initialization
	void Start () {
		camera = GetComponentInChildren<Camera> ();
	}

	// Update is called once per frame
	void Update () {
		float rotationSpeed = 5.0f;
		float mouseX = Input.GetAxis ("Mouse X") * rotationSpeed;
		float mouseY = Input.GetAxis ("Mouse Y") * rotationSpeed;


		// We're rotating ABOUT the Y axis. Think of the y axis as a stick. And we rotate around it.
		// This means we're technically change the horizontal view
		transform.localRotation = Quaternion.Euler (0, mouseX, 0) * transform.localRotation;

		// rotate the camera about the X axis.
		camera.transform.localRotation = Quaternion.Euler(-mouseY, 0, 0) * camera.transform.localRotation;

	}
}
