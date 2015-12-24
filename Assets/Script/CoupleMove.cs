using UnityEngine;
using System.Collections;

public class CoupleMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float flag = 1;
		float rand=Random.value;


		Vector3 direction=new Vector3 (5*flag*rand, 0, 0);
		Vector3 current_position = transform.position;
		transform.position = current_position+Time.deltaTime * direction;
	}
}
