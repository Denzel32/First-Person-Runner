using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour 
{	
	public GUIStyle restartButStyle;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI()
	{	
		GUI.skin.button = restartButStyle;
		//GUI.Label(new Rect(Screen.width / 2,Screen.height / 2  , 100 , 100 ), "You died");


		if(GUI.Button (new Rect(Screen.width / 2, Screen.height / 2, 200, 50), ""))
		{	
			Application.LoadLevel("playscene");
		}
		
	}
}
