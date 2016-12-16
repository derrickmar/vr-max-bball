using UnityEngine;
using System.Collections;

public class BallLauncher : MonoBehaviour {

	public GameObject ballPrefab;
	public float speed = 15.0f;
	Camera camera;

	// Use this for initialization
	void Start () {
		camera = GetComponentInChildren<Camera> ();
	}
	
	// Update is called once per frame

	void Update () {
		GameObject instance;

		if (Input.GetButtonDown ("Fire1")) {
			instance = Instantiate (ballPrefab);
//			instance.transform.position = transform.position + new Vector3 (0, 0.4f, 0);
			instance.transform.position = transform.position;
			Rigidbody rb = instance.GetComponent<Rigidbody> ();

			// Rotate the vector to the same viewpoint of the camera;
			Vector3 CameraVectorDir = camera.transform.rotation * (Vector3.forward + new Vector3(0, 0.1f, 0));
//			Vector3 CameraVectorDir = camera.transform.rotation * Vector3.forward;
			// velocity is speed and direction
			rb.velocity = CameraVectorDir * speed;
		}
	}
}
