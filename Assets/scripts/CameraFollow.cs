﻿using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
	
	public Texture2D crosshairImage;

	void OnGUI()
	{
		// Croshairs
		float xMin = (Screen.width / 2) - (crosshairImage.width / 2);
		float yMin = (Screen.height / 2) - (crosshairImage.height / 2);
		GUI.DrawTexture (new Rect (xMin, yMin, crosshairImage.width, crosshairImage.height), crosshairImage);
	}
}
