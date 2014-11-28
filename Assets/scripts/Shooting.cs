using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {

	public Transform BarrelEnd;
	public Transform Poof;
	public Transform BulletObj;

	void Update () 
	{

		if (Input.GetKeyDown (KeyCode.Mouse0)) 
		{
			Instantiate (Poof, BarrelEnd.position, BarrelEnd.rotation);
			Instantiate (BulletObj, BarrelEnd.position, BarrelEnd.rotation);
		}
	}
}
