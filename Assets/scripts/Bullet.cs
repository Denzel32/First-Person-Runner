using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	
	private int Desptimer;
	private float speed = 1f;
	public AudioClip hitsound;

	void Update () 
	{
		this.transform.Translate(Vector3.up * speed);
		Desptimer ++;
		if (Desptimer >= 130)
			Destroy (this.gameObject);
	}

	void OnTriggerEnter(Collider other)
	{	

		if (other.gameObject.tag == "Rock") 
		{	
			audio.Play();
			Destroy (other.gameObject);
		}
		if (other.gameObject.tag == "RockTwo") 
		{	
			audio.Play();
			Destroy (other.gameObject);
		}
	}
}
