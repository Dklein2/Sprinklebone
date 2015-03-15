using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class menuManager : MonoBehaviour 
{
	public menuScript CurrentMenu;
	public void Start()
	{

		ShowMenu(CurrentMenu);

	}

	public void ShowMenu(menuScript menu)
	{
		if (CurrentMenu != null)
			CurrentMenu.IsOpen = false;

		CurrentMenu = menu;
		CurrentMenu.IsOpen = true;
	}


}
