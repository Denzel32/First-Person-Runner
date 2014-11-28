using UnityEngine;
using System.Collections;

public class RockMovement : MonoBehaviour 
{	
	private float moveSpeed;
	public float minMoveSpeed = 15f;
	public float maxMoveSpeed = 25f;

	// Use this for initialization
	void Start () 
	{
		moveSpeed = Random.Range (minMoveSpeed,maxMoveSpeed);
	}
	
	// Update is called once per frame
	void Update () 
	{	
		transform.Translate(Vector3.forward *-  moveSpeed * Time.deltaTime);
	}

}
