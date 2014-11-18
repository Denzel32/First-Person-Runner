using UnityEngine;
using System.Collections;

public class PlatformSpawn : MonoBehaviour 
{	
	[SerializeField]
	private GameObject platform;
	public int platforms = 0;
	private float spawnposz = 20f; 


	// Use this for initialization
	void Start () 
	{	

		//StartCoroutine(Spawn());
	}

	void Update()
	{
		if(platforms < 5)
		{
			platforms ++;
			Instantiate(platform,new Vector3(Random.Range(1,20),Random.Range(1,6),spawnposz),transform.rotation);
			spawnposz += 20;
		}
	}

	public void RemovePlatform()
	{
		platforms --;
	}

}
