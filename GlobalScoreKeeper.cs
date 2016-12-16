using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class GlobalScoreKeeper : MonoBehaviour {

	public int score = 0;
	int currentIndex = -1;
	// Duration in milliseconds
	int currDuration = 2500;
	List<int> x_samples = new List<int> { };  
	List<int> y_samples = new List<int> { };

	public Dictionary<string, double> currDist = new Dictionary<string, double> {
		{ "rest", 0.0 },
		{ "slow", 1.0 },
		{ "medium", 0.0 },
		{ "fast", 0.0 },
		{ "superfast", 0.0 } };

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (this.gameObject);
	}

	public void IncrementScore() {
		score++;
		print ("score is " + score);
	}

	public void reset() {
		OSCHandler.Instance.SendMessageToClient("Max", "/reset", 1);
		currentIndex = -1;
		x_samples = new List<int> { };
		y_samples = new List<int> { };
		int currDuration = 2500;
		OSCHandler.Instance.SendMessageToClient("Max", "/seq/samps/x", x_samples);
		OSCHandler.Instance.SendMessageToClient("Max", "/seq/samps/y", y_samples);
		OSCHandler.Instance.SendMessageToClient("Max", "/dur", currDuration);
	}

	public void changePhaseSpeed(int delta) {
		currDuration += delta;
		OSCHandler.Instance.SendMessageToClient("Max", "/dur", currDuration);
	}

	// Changes the speed of a certain instrument
	public void changeSpeed(string mode) {
		if (currentIndex < 0) {
			return;
		}
		currDist[mode] += 1;
		OSCHandler.Instance.SendMessageToClient("Max", "/weights/" + currentIndex, new List<double> (currDist.Values));
	}

	public void AddInstrument(int instrumentIndex) {
		currentIndex += 1;
		x_samples.Add (currentIndex);
		y_samples.Add (instrumentIndex);
		OSCHandler.Instance.SendMessageToClient("Max", "/reset", 0);
		OSCHandler.Instance.SendMessageToClient("Max", "/seq/samps/x", x_samples);
		OSCHandler.Instance.SendMessageToClient("Max", "/seq/samps/y", y_samples);
		currDist = new Dictionary<string, double> {
			{ "rest", 0.0 },
			{ "slow", 1.0 },
			{ "medium", 0.0 },
			{ "fast", 0.0 },
			{ "superfast", 0.0 } };
		OSCHandler.Instance.SendMessageToClient("Max", "/weights/" + currentIndex, new List<double> (currDist.Values));
	}
}
