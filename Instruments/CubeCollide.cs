using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CubeCollide : MonoBehaviour {
	private GlobalScoreKeeper scoreKeeper;
	Texture tex;
	int instrumentIndex;

	bool alreadyCollidedWithBall = false;
	Dictionary<int, string> images = new Dictionary<int, string> {
		{ 0, "rest" },
		{ 1, "clhihat" },
		{ 2, "claves" },
		{ 3, "conga1" },
		{ 4, "cowbell" },
		{ 5, "crashcym" },
		{ 6, "handclap" },
		{ 7, "hiconga" },
		{ 8, "hightom" },
		{ 9, "kick1" },
		{ 10, "kick2" },
		{ 11, "maracas" },
		{ 12, "openhh" },
		{ 13, "rimshot" },
		{ 14, "snare" },
		{ 15, "tom1" } };

	void Start () {
		scoreKeeper = FindObjectOfType<GlobalScoreKeeper> ();
		setInstrument ();
	}
		
	void setInstrument() {
		instrumentIndex = Random.Range (0, images.Count);
		string imageName = images[instrumentIndex];
		tex = Resources.Load(imageName) as Texture;
		this.gameObject.GetComponent<Renderer>().material.mainTexture = tex;
	}

	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag == "ball" && !alreadyCollidedWithBall) {
//			print ("Colliding yeah!!");
			scoreKeeper.AddInstrument (instrumentIndex);
			alreadyCollidedWithBall = true;
			Explode ();
		}

		if (collision.gameObject.tag == "ground") {
			Destroy (this.gameObject);
		}
	}

	void Explode() {
		var exp = GetComponent<ParticleSystem>();
		exp.Play();
		Destroy(gameObject, exp.duration - 1.0f);
	}
}
