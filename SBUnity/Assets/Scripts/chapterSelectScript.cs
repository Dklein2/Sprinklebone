using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class chapterSelectScript : MonoBehaviour {
	public Button btn;
	public int temp = 3;
	public int chapterNumber;


	// Use this for initialization
	void Start () {
		btn.onClick.AddListener(() => checkStatus ());
	}
	
	void checkStatus()
	{
		if (temp >= chapterNumber)
		{
			Debug.Log("Unlocked");
			GameObject.Find("chapter"+chapterNumber.ToString() +"Text").GetComponent<Text>().text = "";
		}
		else
		{
			Debug.Log("Locked");
			GameObject.Find("chapter"+chapterNumber.ToString() +"Text").GetComponent<Text>().text = "LOCKED";
		}

	}
}
