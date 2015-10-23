using UnityEngine;
using System.Collections;

public class cube_show : MonoBehaviour {

	Transform role_pos;
	int count;

	// Use this for initialization
	void Start () {
		count = 0;
		transform.localPosition = new Vector3(Random.Range(-5, 5),0.025f,Random.Range(-5, 5));
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other) {
//		Destroy(other.gameObject);
		count++;
		Debug.Log (count);
		transform.localPosition = new Vector3(Random.Range(-5, 5),0.025f,Random.Range(-5, 5));
//		Destroy ();

	}

}
