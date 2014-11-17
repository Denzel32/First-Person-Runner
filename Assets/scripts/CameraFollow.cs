using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public Transform Player;

	void Start () 
	{
	
	}

	void Update () 
	{
		this.transform.position = new Vector3 (Player.transform.position.x, Player.transform.position.y + 2.4f, Player.transform.position.z - -1);
	}
}
