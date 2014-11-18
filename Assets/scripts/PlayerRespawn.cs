using UnityEngine;
using System.Collections;

public class PlayerRespawn : MonoBehaviour 
{	
	public Transform spawnpoint;
	public Transform mytransform;
	private int spawnCount = 3;
	//public Transform spawnpoint;
	
	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		Respawn();
	}
	
	void Respawn()
	{
		if(transform.position.y <= -50)
		{
			spawnCount--;
			Vector3 newposition = transform.position;
			newposition.x = 0;
			newposition.y = 0;
			newposition.z = 2;
			transform.position = newposition;
			//Destroy(this.gameObject);
			//Instantiate(spawnpoint, new Vector3(2,2,0), Quaternion.identity);
			if(spawnCount == 0)
			{
				//Destroy(this.gameObject);
				Application.LoadLevel("gameoverscreen");
			}

		}
	}
}
