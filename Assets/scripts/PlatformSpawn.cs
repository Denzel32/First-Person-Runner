using UnityEngine;
using System.Collections;

public class PlatformSpawn : MonoBehaviour 
{	
	[SerializeField]
	private GameObject platform;
	public int platforms = 0;
	private float spawnposz = 10f; 
	//GameObject
	//public GameObject [] obj ;
	/*public float spawnmin = 1f;
	public float spawnmax = 2;
	public Vector3 pos = new Vector3(-10,-4,-4);
	public float size = 1.0f;
	private Vector3 dir = Vector3.forward;
	*/

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
			Instantiate(platform,new Vector3(Random.Range(5,6),Random.Range(0,3),spawnposz),transform.rotation);
			spawnposz += 5;
		}
	}

	public void RemovePlatform()
	{
		platforms --;
	}
	// Update is called once per frame
	/*IEnumerator Spawn()
	{
		while(true)
		{	
			Instantiate(obj[Random.Range (0, obj.Length)], pos, Quaternion.identity);
			pos += dir * size;
			yield return new WaitForSeconds(Random.Range (spawnmin, spawnmax));
		}
	}*/
}
