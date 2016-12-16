using UnityEngine;
using System.Collections;
using UnityOSC;

public class DroppingCubes : MonoBehaviour {
	public GameObject cubePrefab;
	float timeSinceStart = 0;

	void Start () {
		OSCHandler.Instance.Init(); 
	}

	// Update is called once per frame
	void Update () {
		if (Mathf.Round(Time.time) > timeSinceStart) {
			timeSinceStart = Mathf.Round (Time.time) + 1;
			createDroppingCubes (1);
		}
	}

	void createDroppingCubes(int numCubes) {
		while (numCubes > 0) {
			GameObject cube = Instantiate (cubePrefab);
			cube.transform.position = new Vector3 (Random.Range (2.5f, 3.5f), 15f, Random.Range (-8f, 4f));
			Rigidbody r = cube.GetComponent<Rigidbody> ();
			r.angularVelocity = new Vector3 (Random.Range (-1f, 1f), Random.Range (-1f, 1f), Random.Range (-1f, 1f));
			numCubes -= 1;
		}
	}
}
