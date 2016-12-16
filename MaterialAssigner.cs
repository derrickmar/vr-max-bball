using UnityEngine;
using System.Collections;

public class MaterialAssigner : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print ("WORKING??");
		Texture tex = Resources.Load("cowbell") as Texture;
		this.GetComponent<Renderer>().material.mainTexture = tex;
		print ("HELLO");
	}
	
	// Update is called once per frame
	void Update () {
	}
}
