using UnityEngine;
using System.Collections;


public class creat_cube : MonoBehaviour {
	


	GameObject obj;

	public UILabel label_time;
	public int allNum = 1;
	public int level = 1;

	private float allTime;
	private float starttime;
	private int count = 0;

	private bool isover = false;
	// Use this for initialization
	void Start () {
		starttime = Time.time;

		Debug.Log ("starttime" + starttime);
		//startlevel*20 seconds is game time;
		allTime = level * 20;
		obj = Resources.Load("Cube") as GameObject;
		label_time = GameObject.Find ("Label").GetComponentInChildren<UILabel>();


		creatCube (allNum);
	}


	void creatCube(int num)
	{

		GameObject[] objs = new GameObject[num];
		
		
		for (int i = 0; i < num; i++) {
			
			objs[i] = Instantiate(obj,new Vector3(Random.Range(-50, 50),0.25f,Random.Range(-50, 50)),obj.transform.localRotation) as GameObject;
			objs[i].transform.SetParent(transform,true);
			objs[i].GetComponent<cube_show>().trigger += addCount;
		}
	}
	
	// Update is called once per frame
	void Update () {

		allTime -= Time.deltaTime;

		if (allTime < 0) {
			if(!isover){
				gameover ();
				label_time.text = "00:00";
			}
		} else {
			int minute = 0;
			int second = 0;
			minute = Mathf.FloorToInt(allTime / 60);
			second = Mathf.FloorToInt(allTime % 60);
			label_time.text = minute.ToString("00") + ":" + second.ToString("00");
		}
	}

	void gameover()
	{
		Debug.Log("gameover");
		//use that to stop game
		allNum = 100000;
		isover = true;
	}

	void addCount(){
		count++;
		Debug.Log ("count =="+count);

		if (count == allNum) {
			//level up
			level++;

			//time add 20seconds
			allTime += 20;
			//cube num add 2
			Debug.Log("time next"+allTime);
			allNum +=2;
			count = 0;

			//start next level
			creatCube(allNum);

		}
	}

	void OnGUI()
	{


		GUI.Box(new Rect(Screen.width -260, 10 ,250 ,150), "Interaction");
		GUI.Label(new Rect(Screen.width -245,30,250,30),"Up/Down Arrow : Go Forwald/Go Back");
		GUI.Label(new Rect(Screen.width -245,50,250,30),"Left/Right Arrow : Turn Left/Turn Right");
		GUI.Label(new Rect(Screen.width -245,70,250,30),"Hit Space key while Running : Jump");
		GUI.Label(new Rect(Screen.width -245,90,250,30),"Hit Spase key while Stopping : Rest");
		GUI.Label(new Rect(Screen.width -245,110,250,30),"Left Control : Front Camera");
		GUI.Label(new Rect(Screen.width -245,130,250,30),"Alt : LookAt Camera");
	}
}
