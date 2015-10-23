using UnityEngine;
using System.Collections;

public class creat_cube : MonoBehaviour {
	
	GameObject[] objs;

	GameObject obj;
	// Use this for initialization
	void Start () {
		int randomNum = Random.Range (1, 6);
		objs = new GameObject[randomNum];
		obj = Resources.Load("Cube") as GameObject;


		for (int i = 0; i < randomNum; i++) {

			objs[i] = Instantiate(obj,new Vector3(Random.Range(-5, 5),0.025f,Random.Range(-5, 5)),obj.transform.localRotation) as GameObject;
			objs[i].transform.SetParent(transform,true);
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
