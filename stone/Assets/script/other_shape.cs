using UnityEngine;
using System.Collections;

public class other_shape : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}


	public delegate void EventHandler(string num);
	public event EventHandler OnSendMessage;


	// Update is called once per frame
	void Update () {
		if (gameObject.name == "Cube"&&Input.GetKeyDown ("1")) {
			SendMessageUpwards("ApplyMessage", gameObject.name);
		}
	}

	void ApplyMessage(string name)  
	{  
		Debug.Log("The name is :" + gameObject.name); 
	} 

	void OnTriggerEnter(Collider other) {
		Debug.Log("hah+"+other.name);

		if (OnSendMessage != null) {
			OnSendMessage(gameObject.name);
			Debug.Log("isn't null");
		}
	}
}
