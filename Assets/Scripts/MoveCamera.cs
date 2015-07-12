using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour
{
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey (KeyCode.A)) {
			print ("A");
			//gameObject.transform.position = new Vector3 (transform.position.x - 0.6f, transform.position.y);
			gameObject.transform.position = new Vector3 (
				gameObject.transform.position.x - 0.6f, 
				gameObject.transform.position.y, 
				gameObject.transform.position.z);
		}
		if (Input.GetKey (KeyCode.D)) {
			print ("D");
			//gameObject.transform.position = new Vector3 (transform.position.x + 0.6f, transform.position.y);
			gameObject.transform.position = new Vector3 (
				gameObject.transform.position.x + 0.6f, 
				gameObject.transform.position.y, 
				gameObject.transform.position.z);
		}
		if (Input.GetKey (KeyCode.W)) {
			print ("W");
			gameObject.transform.position = new Vector3 (
				gameObject.transform.position.x, 
				gameObject.transform.position.y, 
				gameObject.transform.position.z + 0.6f);
		}
		if (Input.GetKey (KeyCode.S)) {
			print ("S");
			gameObject.transform.position = new Vector3 (
				gameObject.transform.position.x, 
				gameObject.transform.position.y, 
				gameObject.transform.position.z - 0.6f);
		}
		if (Input.GetKey (KeyCode.KeypadMinus)) {
			gameObject.transform.position = new Vector3 (transform.position.x, transform.position.y + 0.6f);
		}
		if (Input.GetKey (KeyCode.KeypadPlus)) {
			gameObject.transform.position = new Vector3 (transform.position.x, transform.position.y - 0.6f);
		}

		transform.Translate (Vector3.down * Input.GetAxis ("Mouse ScrollWheel") * 10);
	}
	
}
