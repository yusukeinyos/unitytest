using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {

	Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 direction=new Vector3 (2, 1, 0);
		Vector3 current_position = transform.position;
		transform.position = current_position+Time.deltaTime * direction;
	}

	void OnTriggerEnter(Collider other) 
	{
		
		//Instantiate(explosion, transform.position, transform.rotation);
		
		Destroy(other.gameObject);
		Destroy(gameObject);
	}
}
