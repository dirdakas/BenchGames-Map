using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		/*print (GameObject.FindGameObjectsWithTag("Zones"));
		if (Input.GetMouseButtonDown (0)) {

		}*/
		//print (gameObject.transform.position);

		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (Input.GetMouseButton (0)) {
			if (Physics.Raycast (ray, out hit, 100)) {
				Debug.DrawLine (ray.origin, hit.point);
				print (hit.collider.name);
				gameObject.transform.position = hit.transform.position;
				hit.transform.gameObject.GetComponent<Renderer>().material.color = Color.red;
			}
		}

	}
}
