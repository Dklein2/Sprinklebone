using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;

public class profileManager : MonoBehaviour 
{
	INIParser ini = new INIParser();
	private string appData =System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
	public bool isStart;
	public Text txt;
	public Button btn;
	public Button deletedButton;
	public enum argType{pass,set,delete};
	public argType isDoing; 
	public static string buttonClicked;
	public static string selectedProfile;
	private GameObject autoS;  




	public void Start()
	{


		if (isStart ==true)
		{
				ini.Open("C:/sbProfiles.ini");
				txt.text = ini.ReadValue(txt.name,"Name","Create New Profile" ) ;
				ini.Close();
		}
		else{}
		if (isDoing == argType.pass)
		{
			btn.onClick.AddListener(() => passButton ());
		}
		else if (isDoing == argType.set)
		{
			btn.onClick.AddListener(() => setProfile ());
		}
		else if (isDoing ==argType.delete)
		{
			btn.onClick.AddListener(() => deleteProfile());
		}

	}

	public void passButton()
	{
		Debug.Log("passing variable");
		buttonClicked = txt.name;
		Debug.Log(buttonClicked);
		selectedProfile = txt.text;
		Debug.Log(selectedProfile);

		if (txt.text == "Create New Profile" || txt.text == "" || txt.text == " " || txt.text == "  " || txt.text =="   ")
		{
			autoS = GameObject.Find("Canvas");
			menuManager other = (menuManager) autoS.GetComponent(typeof(menuManager));
			other.ShowMenu(GameObject.Find("userInputMenu").GetComponent<menuScript>());

		}
		else
		{
			autoS = GameObject.Find("Canvas");
			menuManager other = (menuManager) autoS.GetComponent(typeof(menuManager));
			other.ShowMenu(GameObject.Find("mainMenu").GetComponent<menuScript>());
		}

	}

	public void setProfile()
	{
		Debug.Log("Setting variable");
		selectedProfile = txt.text;
		ini.Open("C:/sbProfiles.ini");
		ini.WriteValue(buttonClicked,"Name",selectedProfile ) ;
		//Debug.Log(buttonClicked);
		//Debug.Log(selectedProfile);
		ini.Close();
		GameObject.Find(buttonClicked).GetComponent<Text>().text = selectedProfile;

		for (int i=0; i<5; i++)
		{
			string count = i.ToString();
			if (i==0)
			{
				autoS = GameObject.Find("autosaveButton");
				Debug.Log ("autosaveButton");
			}
			else
			{
				autoS = GameObject.Find("s"+count+"Button");
				Debug.Log("s"+count+"Button");
			}
			saveLoadScript other = (saveLoadScript) autoS.GetComponent(typeof(saveLoadScript));
			other.updateNames();
		}

	}

	public void deleteProfile()
	{
		//Delete all save files associated with the profile
		//File.Delete(appData + "/../Local/VirtualStore/sprinkleboneTest.ini");

		ini.Open("C:/sbProfiles.ini");
		ini.KeyDelete(txt.name,"Name");
		ini.Close ();
		GameObject.Find(txt.name).GetComponent<Text>().text = "Create New Profile";
	
	}





		

		
}


