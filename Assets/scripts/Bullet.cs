using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	
	private int Desptimer;

	void Update () 
	{
		Desptimer ++;
		if (Desptimer >= 130)
			Destroy (this.gameObject);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Wall") 
		{
			Destroy (other.gameObject);
		}
	}
}
