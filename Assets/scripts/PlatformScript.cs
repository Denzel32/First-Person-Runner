using UnityEngine;
using System.Collections;

public class PlatformScript : MonoBehaviour 
{	
	private Transform player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{	
		if(player != null)
		{
			if(player.position.z - this.transform.position.z > 10)
			{
				GameObject newcamera = GameObject.FindGameObjectWithTag("MainCamera");
				newcamera.GetComponent<PlatformSpawn>().RemovePlatform();
				player = null;
				Destroy(this.gameObject);
			}
		}
	}

	void OnCollisionEnter(Collision collide)
	{
		player = collide.transform;
	}
}
