using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour 
{	
	public float jumpSpeed = 50f;
	public float movementSpeed = 50f;
	private bool jump = true;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{	
		if(Input.GetKeyDown(KeyCode.W))
		{
			if(jump == true)
			{
				//rigidbody.AddForce(Vector3.up * jumpSpeed);
				rigidbody.velocity = new Vector3 (0,10,0);

				jump = false;
			}
		}

		if(Input.GetKey(KeyCode.D))
		{
			//rigidbody.AddForce(Vector3.right * movementSpeed);
			transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);
		}

		if(Input.GetKey(KeyCode.A))
		{
			transform.Translate(Vector3.right * - movementSpeed * Time.deltaTime);
		}
		//print ("im working");
	}
	void OnCollisionEnter(Collision collide)
	{
		if(collide.gameObject.tag == "Ground")
		{
			jump = true;
		}
	}
}
