using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	private float speed = 0.5f;
	public Transform Explosion;
	private int Desptimer;

	private Score scoreVar;
	private GUIText Scoretext;

	void Start()
	{
		scoreVar = GameObject.FindGameObjectWithTag("GUITextTag").GetComponent<Score> ();
	}

	void Update () 
	{
		this.transform.Translate (Vector3.up * speed);
		Desptimer ++;
		if (Desptimer >= 350)
			Destroy (this.gameObject);
	}

	void OnTriggerEnter(Collider other)
	{
		Destroy(this.gameObject);		
		Instantiate (Explosion, transform.position, transform.rotation);
		if (other.gameObject.tag == "Boulder") 
		{
			Destroy (other.gameObject);
			scoreVar.ScoreNum ++;
		}
	}
}
