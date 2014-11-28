using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour 
{	
	private int playerHealth = 3;
	
	// Update is called once per frame
	void Update () 
	{
		PlayerDeath();
		
	}

	void OnGUI()
	{
		GUI.Label(new Rect(10, 10, 100, 20), "Lives left " + playerHealth);
	}
	
	void OnCollisionEnter(Collision collide)
	{
		if(collide.gameObject.tag == "Rock")
		{
			playerHealth--;
			//sprint(playerHealth);
		}
	}
	
	void PlayerDeath()
	{
		if(transform.position.y <= -50)
		{
			playerHealth = 0;

		}

		if(playerHealth <= 0)
		{
			Application.LoadLevel("gameoverscreen");
		}
	}
}