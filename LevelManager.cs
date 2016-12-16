using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public float timeTillNextLevel = 5.0f;
	public bool canProgress = false;

	// Use this for initialization
	void Start () {
		print ("STARTING LEVEL MANAGER");
	}
	
	// Update is called once per frame
	void Update () {
//		if (Input.GetKeyDown (KeyCode.Space)) {
//			print ("space key pressed");
//			GoToScene (GoToNextSceneIndex());  
//		}
		timeTillNextLevel -= Time.deltaTime;
//		print ("timeTillNextLevel " + timeTillNextLevel);
		if (timeTillNextLevel < 0 && canProgress) {
			GoToScene (GoToNextSceneIndex());  
		}
	}

	public int GoToNextSceneIndex() {
		return SceneManager.GetActiveScene ().buildIndex + 1;
	}

	public void GoToScene(int index) {
		SceneManager.LoadScene (index);
	}
}
