using UnityEngine;
using System.Collections;

public class ObstacleSpawn : MonoBehaviour 
{	
	public GameObject Obstacle;

	// Use this for initialization
	void Start () 
	{
		Invoke("CreateMyInstance",3.0f);
	}
	
	// Update is called once per frame
	void Update () 
	{	

	}

	void CreateMyInstance()
	{
		Instantiate(Obstacle, new Vector3(0,5,20),Quaternion.identity);
	}
}
