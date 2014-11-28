using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour 
{	
	public float jumpSpeed = 50f;
	public float movementSpeed = 50f;
	private bool jump = true;

	public float mouseSensitivity = 5.0f;
	
	float verticalRotation = 0;
	public float upDownRange = 30.0f;
	public AudioClip JumpSound;

	// Use this for initialization
	void Start () 
	{
		Screen.lockCursor = true;
	}
	
	// Update is called once per frame
	void Update () 
	{	
		//rotation

		float rotLeftRight = Input.GetAxis("Mouse X") * mouseSensitivity;
		transform.Rotate (0, rotLeftRight, 0);
		
		verticalRotation -= Input.GetAxis ("Mouse Y") * mouseSensitivity;
		verticalRotation = Mathf.Clamp (verticalRotation, -upDownRange - 30, upDownRange);
		Camera.main.transform.localRotation = Quaternion.Euler (verticalRotation, 0, 0);

		if(Input.GetKey(KeyCode.W))
		{
			transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
		}

		if(Input.GetKey(KeyCode.S))
		{
			transform.Translate(Vector3.forward * - movementSpeed * Time.deltaTime);
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


		if(Input.GetKeyDown(KeyCode.Space))
		{
			if(jump == true)
			{	
				//rigidbody.AddForce(Vector3.up * jumpSpeed);
				rigidbody.velocity = new Vector3 (0,10,0);
				audio.Play();
				jump = false;
			}
		}

	}
	void OnCollisionEnter(Collision collide)
	{
		if(collide.gameObject.tag == "Ground")
		{
			jump = true;
		}
		if(collide.gameObject.tag == "Wall")
		{
			jump = true;
		}
	}
}
