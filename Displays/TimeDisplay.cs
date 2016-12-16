using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class TimeDisplay : MonoBehaviour {

	LevelManager levelManager;
	Text timeText;

	// Use this for initialization
	void Start () {
		timeText = GetComponent<Text> ();
		levelManager = FindObjectOfType<LevelManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		timeText.text = "Time Remaining: " + (int)Math.Round(levelManager.timeTillNextLevel, 0);
	}
}
