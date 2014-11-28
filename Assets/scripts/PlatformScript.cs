using UnityEngine;
using System.Collections;

public class PlatformScript : MonoBehaviour 
{	
	private Transform player;
	//private int direction = 1;
	//public float moveSpeed = 2.0f;
	private Vector3 startpos;
	public float maxOffset = 10f;

	// Use this for initialization
	void Start () 
	{	
		startpos = transform.position;
	
	}
	
	// Update is called once per frame
	void Update () 
	{	
		/*transform.Translate(Vector3.right * moveSpeed * direction * Time.deltaTime);

		if(transform.position.x > startpos.x + maxOffset)
		{
			direction = -1;
		}
		else if(transform.position.x < startpos.x - maxOffset)
		{
			direction = 1;
		}*/
		
		if(player != null)
		{
			if(player.position.z - this.transform.position.z > 10)
			{
				GameObject newcamera = GameObject.FindGameObjectWithTag("GameManager");
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
