using UnityEngine;
using System.Collections;

public class RockSpawn : MonoBehaviour 
{	
	public GameObject [] obj;
	public GameObject spwnmnger;
	//public GameObject spawnedObject;

	// Use this for initialization
	void Start () 
	{
		StartCoroutine(Spawner ());
	}
	
	IEnumerator Spawner()
	{
		for(int i = 0; i < 100; i++)
		{	
			Instantiate(obj[Random.Range(0,obj.GetLength(0))],new Vector3(Random.Range(-5,5),Random.Range(0,4),spwnmnger.transform.position.z), Quaternion.identity);
			Instantiate(obj[Random.Range(0,obj.GetLength(0))],new Vector3(Random.Range(-5,5),Random.Range(0,4),spwnmnger.transform.position.z), Quaternion.identity);
			Instantiate(obj[Random.Range(0,obj.GetLength(0))],new Vector3(Random.Range(-5,5),Random.Range(0,4),spwnmnger.transform.position.z), Quaternion.identity);
			Instantiate(obj[Random.Range(0,obj.GetLength(0))],new Vector3(Random.Range(-5,5),Random.Range(0,4),spwnmnger.transform.position.z), Quaternion.identity);

			//Instantiate(spawnedObject,this.transform.position,this.transform.rotation);

			yield return new WaitForSeconds(Random.Range(3,8));
		}

	}

}
