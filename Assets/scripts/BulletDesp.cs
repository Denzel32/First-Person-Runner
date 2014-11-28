using UnityEngine;
using System.Collections;

public class BulletDesp : MonoBehaviour {

	private int timer = 0;
	void Update () 
	{
		timer ++;
		if (timer >= 130)
			Destroy (this.gameObject);
	}
}
