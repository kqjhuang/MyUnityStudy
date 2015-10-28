using UnityEngine;
using System.Collections;

public class test_plane : MonoBehaviour {

	// Use this for initialization
	public GameObject obj;
	void Start () {
		evt = obj.GetComponent<other_shape>();
		evt.OnSendMessage += ReceiveMessage;
	}
	
	// Update is called once per frame
	void Update () {

	}


	private other_shape evt = null;

	public void ApplyMessage(string name)  
	{  
		Debug.Log("The name is :" + gameObject.name); 

	} 

	

	void ReceiveMessage(string num)
	{
		Debug.Log("ReceiveMessage="+num);
	}
}
