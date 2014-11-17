using UnityEngine;
using System.Collections;

public class StartScreen : MonoBehaviour 
{	
	public GUIStyle startButStyle;


	void Start()
	{

	}

	void OnGUI()
	{	
		GUI.skin.button = startButStyle;
		if(GUI.Button (new Rect(Screen.width / 2, Screen.height / 2, 200, 50), ""))
		{
			Application.LoadLevel("playscene");
		}
	}
}
