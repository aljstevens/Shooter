using UnityEngine;
using System.Collections;

public class GunShoot : MonoBehaviour {

	public GameObject Flash;
	public GameObject Barrel;

	private GameObject FlashObject;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetButtonDown ("Fire1"))
		{
			FlashObject = Instantiate (Flash, Barrel.transform.position, Barrel.transform.rotation) as GameObject;
			FlashObject.transform.parent = gameObject.transform;
		}
	}
}
