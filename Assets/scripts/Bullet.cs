using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public float bulletSpeed = 25f;
	private int Desptimer;

	void Start () {
	
	}

	void Update () 
	{
		Desptimer ++;
		this.transform.Translate (Vector3.up * bulletSpeed);
		if (Desptimer >= 200)
			Destroy (this.gameObject);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Wall") 
		{
			Destroy (other.gameObject);
		}
		Destroy (this.gameObject);
	}
}
