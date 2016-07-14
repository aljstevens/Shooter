using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {

	Rigidbody rigidBody;
	public float speed = 4;
	public bool WPress;
	public bool SPress;
	public bool APress;
	public bool DPress;

	Vector3 lookPos;

	// Use this for initialization
	void Start ()
	{
		rigidBody = GetComponent<Rigidbody> ();
	}

	void Update ()
	{
		if (Input.GetKeyUp (KeyCode.W))
		{
			WPress = false;
		}

		if (Input.GetKeyDown (KeyCode.W))
		{
			WPress = true;
		}

		if (Input.GetKeyUp (KeyCode.D))
		{
			DPress = false;
		}

		if (Input.GetKeyDown (KeyCode.D))
		{
			DPress = true;
		}

		if (Input.GetKeyUp (KeyCode.A))
		{
			APress = false;
		}

		if (Input.GetKeyDown (KeyCode.A))
		{
			APress = true;
		}

		if (Input.GetKeyUp (KeyCode.S))
		{
			SPress = false;
		}

		if (Input.GetKeyDown (KeyCode.S))
		{
			SPress = true;
		}

		if (SPress == true || APress == true || DPress == true || WPress == true)
		{
			GetComponent<Animation>().Play("soldierRun");
			speed = 5f;
		}

		if (SPress == false && APress == false && DPress == false && WPress == false)
		{
			speed = 0f;
			GetComponent<Animation>().Play("soldierIdle");
		}

		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

		RaycastHit hit;

		if (Physics.Raycast (ray, out hit, 100))
		{
			lookPos = hit.point;
		}

		Vector3 lookDir = lookPos - transform.position;
		lookDir.y = 0;

		transform.LookAt (transform.position + lookDir, Vector3.up);
	}

	// Update is called once per frame
	void FixedUpdate ()
	{
		//if 

		float horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (horizontal, 0, vertical);
		GetComponent<Rigidbody>().velocity = movement * speed;

		//rigidBody.AddForce (movement * speed /Time.deltaTime);
	}

}
