using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;


public class saveLoadScript : MonoBehaviour {

	INIParser ini = new INIParser();
	private string buttonName;
	public Text txt;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	}
	public void updateNames()
	{

			buttonName = txt.name;
			ini.Open("C:/" + profileManager.selectedProfile + buttonName + ".ini");
			if (txt.name == "autosaveText")
			{
				txt.text = ini.ReadValue(txt.name,"Save"," No Autosave Data" ) ;
			}
			else
			{
				txt.text = ini.ReadValue(txt.name,"Save","No Save Data" ) ;
			}
		Debug.Log (txt.name);
			ini.Close();

		


	}
}
