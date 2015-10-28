using UnityEngine;
using System.Collections;

public class cube_show : MonoBehaviour {

	Transform role_pos;
	int count;

	float scaleX;
	float scaleY;
	float scaleZ;
	// Use this for initialization
	void Start () {
		count = 0;
		scaleX = 0.5f / transform.localScale.x;
		scaleY = 0.5f / transform.localScale.y;
		scaleZ = 0.5f / transform.localScale.z;
//		transform.localPosition = new Vector3(Random.Range(-5, 5),0.025f,Random.Range(-5, 5));
	}
	
	// Update is called once per frame
	void Update () {

	}


	public delegate void triggerEventHandler();
	public event triggerEventHandler trigger; 

	void OnTriggerEnter(Collider other) {
//		Destroy(other.gameObject);
		count++;
		Debug.Log (count);
		if (trigger != null) {
			trigger();	
		}
		Destroy (gameObject);
//		transform.localPosition = new Vector3(Random.Range(-50, 50)/scaleX,0.25f/scaleY,Random.Range(-50, 50)/scaleZ);
//		Destroy ();

	}

}
