using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {

	public Transform BarrelEnd;
	public Transform BulletObj;

	void Start () {
	
	}
	

	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Mouse0)) 
		{
			Instantiate (BulletObj, BarrelEnd.position, BarrelEnd.rotation);
		}
	}
}
