using UnityEngine;
using System.Collections;

public class Life : MonoBehaviour {

	private float LightTime =1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		LightTime -= Time.deltaTime;

		if (LightTime <= 0)
		{
			Destroy (gameObject);
		}
	}
}
