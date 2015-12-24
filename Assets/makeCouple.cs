using UnityEngine;
using System.Collections;

public class makeCouple : MonoBehaviour {
	public GameObject couple;
	float nextFire=5;
	float fireRate=5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if ( Time.time > nextFire)
		{
			nextFire = Time.time + fireRate;
			Instantiate(couple, transform.position, transform.rotation);
		}
	}
}
