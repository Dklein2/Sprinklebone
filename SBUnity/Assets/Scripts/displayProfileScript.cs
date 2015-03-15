using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class displayProfileScript : MonoBehaviour 
{
	public Text txt;

	// Update is called once per frame
	void Update () 
	{
		txt.text = profileManager.selectedProfile; 

	}
}
