using UnityEngine;
using System.Collections;

public class test_tou : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		if (other.name.Contains ("Cube2")) {
			Debug.Log ("hah");
		} else {
			Debug.Log("mam");
		}
			

	}
}
