using UnityEngine;
using System.Collections;

public class ObjectDestroyer : MonoBehaviour 
{	
	public float timeInSeconds = 5f;
	public AudioClip hitsound;

	// Use this for initialization
	void Start () 
	{	
		Destroy(gameObject,timeInSeconds);
	}
	
	// Update is called once per frame
	void Update () 
	{	
		
	}
}
