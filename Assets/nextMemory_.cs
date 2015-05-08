using UnityEngine;
using System.Collections;

public class nextMemory_ : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	private bool startedLoad = false;
	void OnMouseDown(){
		if(!startedLoad){
			Application.LoadLevel("OpeningAnimation");
			startedLoad = true;
		}
	}
}
