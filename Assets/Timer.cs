using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Timer : MonoBehaviour {

	float time;
	public float TimeInterval = 5f;
	float tick;
	

	void Awake()
	{
		time = (int)Time.timeSinceLevelLoad;
		tick = TimeInterval;
	}

	

	void Update(){
		GetComponent<Text>().text = string.Format("{0:0}:{1:00}",Mathf.Floor(time/60),time%60);
		time = (int)Time.timeSinceLevelLoad;
		if(time==tick)
		{
			tick = time + TimeInterval;
			TimeExecute();
		}
	}

	void TimeExecute()
	{
		Debug.Log("Finish");
	}
	
	
}