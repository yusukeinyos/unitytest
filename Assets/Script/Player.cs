using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	private Rigidbody rb;

	public float speed;
	public GameObject shot;
	//public Transform shotSpawn;
	float nextFire=1;
	float fireRate=0.5f;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton("Fire1") && Time.time > nextFire)
		{
			nextFire = Time.time + fireRate;
			Vector2 emit_point=transform.position;
			emit_point.y-=1;
			Instantiate(shot, emit_point , transform.rotation);
		}

	}

	void FixedUpdate()
	{
		move ();
	}

	void move()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");		
		Vector2 movement = new Vector2 (moveHorizontal, 0.0f);
		rb.AddForce (movement * speed);
	}


}
	