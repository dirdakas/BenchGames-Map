using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerMovement : MonoBehaviour {
	// Use this for initialization
	private GameObject currentZone = null;
	public GameObject zoneObject;
	public GameObject [][] zoneMovement;
	
	public GameObject [] list;

	private List<string> zoneGreenList = new List<string>();
	private List<string> zoneYellowList = new List<string>();
	private List<string> zoneRedList = new List<string>();
	//zone 1 -> 2,3,5
	void Start () {
		getAllZoneGameObjectsToList ();
		zoneObject = getZoneByName ("Zone9");
		print ("------------");
		print(zoneObject.name);

		//TODO susizinoti kaip i matrica sukelti:
		//zone1 zone2 zone3 zone4...
		//zone2 zone3 zone5
		//zone1 zone3 zone4...
		//for (int i =0; i < list.Length; i++) {
		//	zoneMovement [i][i] = getZoneByName(list[i].name);
		//}
		/*zoneMovement [0] [0] = getZoneByName ("Zone1");
		print (zoneMovement[0][0].name);
		print ("++++++++++");
		print (zoneMovement.Length);
		print (zoneMovement [0].Length);*/

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
				setAvailableZonesColor(hit.transform.gameObject);
				//hit.transform.gameObject.GetComponent<Renderer>().material.color = Color.red;
				currentZone = hit.transform.gameObject;
			}
		}

		//if (currentZone != null) {
		//	print (currentZone.name);
		//}

	}

	void getAllZoneGameObjectsToList ()
	{
		list = GameObject.FindGameObjectsWithTag ("Zones");
		print (list.Length);
		for (int i = 0; i < list.Length; i++) {
			print (list [i].name);
		}
	}

	private GameObject getZoneByName(string name){
		for (int i = 0; i < list.Length; i++){
			if (list[i].name.Equals (name)){
				return list[i];
			}
		}
		return null;
	}

	private void setAvailableZonesColor(GameObject currentZone){
		setAllListsValues(currentZone.name);

		changeZoneColor(zoneGreenList, Color.green);
		changeZoneColor(zoneYellowList, Color.yellow);
		changeZoneColor(zoneRedList, Color.red);
	}

	//TODO fix issue with out of range!!!!
	private void changeZoneColor(List<string> zoneList, Color color){
		for (int i = 0; i < zoneList.Capacity; i++) {
			getZoneByName (zoneList[i]).GetComponent<Renderer> ().material.color = color;
		}
	}

	private void cleanAllZoneLists(){
		if (zoneGreenList != null) {
			changeZoneColor (zoneGreenList, Color.white);
			zoneGreenList.Clear ();
		}
		if (zoneYellowList != null) {
			changeZoneColor (zoneYellowList, Color.white);
			zoneYellowList.Clear ();
		}
		if (zoneRedList != null) {
			changeZoneColor (zoneRedList, Color.white);
			zoneRedList.Clear ();
		}
	}

	private void setAllListsValues(string currentZone){
		switch (currentZone)
		{
		case "Zone1":
			cleanAllZoneLists();
			
			//setGreenList
			zoneGreenList = new List<string>(3);
			zoneGreenList.Add("Zone2");
			zoneGreenList.Add("Zone3");
			zoneGreenList.Add("Zone5");

			//setYellowList
			zoneYellowList = new List<string>(3);
			zoneYellowList.Add("Zone4");
			zoneYellowList.Add("Zone6");
			zoneYellowList.Add("Zone7");

			//setRedList
			zoneRedList = new List<string>(3);
			zoneRedList.Add("Zone8");
			zoneRedList.Add("Zone9");
			zoneRedList.Add("Zone10");
			break;
		case "Zone2":
			cleanAllZoneLists();

			//setGreenList
			zoneGreenList = new List<string>(2);
			zoneGreenList.Add("Zone1");
			zoneGreenList.Add("Zone5");

			//setYellowList
			zoneYellowList = new List<string>(2);
			zoneYellowList.Add("Zone3");
			zoneYellowList.Add("Zone6");
			
			//setRedList
			zoneRedList = new List<string>(4);
			zoneRedList.Add("Zone4");
			zoneRedList.Add("Zone7");
			zoneRedList.Add("Zone8");
			zoneRedList.Add("Zone9");
			break;
		case "Zone3":
			cleanAllZoneLists();

			//setGreenList
			zoneGreenList = new List<string>(4);
			zoneGreenList.Add("Zone1");
			zoneGreenList.Add("Zone4");
			zoneGreenList.Add("Zone5");
			zoneGreenList.Add("Zone7");

			//setYellowList
			zoneYellowList = new List<string>(5);
			zoneYellowList.Add("Zone2");
			zoneYellowList.Add("Zone6");
			zoneYellowList.Add("Zone8");
			zoneYellowList.Add("Zone9");
			zoneYellowList.Add("Zone10");
			
			//setRedList
			zoneRedList = new List<string>(4);
			zoneRedList.Add("Zone8");
			zoneRedList.Add("Zone11");
			zoneRedList.Add("Zone13");
			zoneRedList.Add("Zone14");
			break;
		case "Zone4":
			cleanAllZoneLists();

			//setGreenList
			zoneGreenList = new List<string>(2);
			zoneGreenList.Add("Zone3");
			zoneGreenList.Add("Zone7");

			//setYellowList
			zoneYellowList = new List<string>(5);
			zoneYellowList.Add("Zone1");
			zoneYellowList.Add("Zone5");
			zoneYellowList.Add("Zone6");
			zoneYellowList.Add("Zone9");
			zoneYellowList.Add("Zone10");
			
			//setRedList
			zoneRedList = new List<string>(5);
			zoneRedList.Add("Zone2");
			zoneRedList.Add("Zone8");
			zoneRedList.Add("Zone11");
			zoneRedList.Add("Zone13");
			zoneRedList.Add("Zone14");
			break;
		case "Zone5":
			cleanAllZoneLists();

			//setGreenList
			zoneGreenList = new List<string>(4);
			zoneGreenList.Add("Zone1");
			zoneGreenList.Add("Zone2");
			zoneGreenList.Add("Zone3");
			zoneGreenList.Add("Zone6");

			//setYellowList
			zoneYellowList = new List<string>(4);
			zoneYellowList.Add("Zone4");
			zoneYellowList.Add("Zone7");
			zoneYellowList.Add("Zone8");
			zoneYellowList.Add("Zone9");
			
			//setRedList
			zoneRedList = new List<string>(2);
			zoneRedList.Add("Zone10");
			zoneRedList.Add("Zone11");
			break;
		case "Zone6":
			cleanAllZoneLists();

			//setGreenList
			zoneGreenList = new List<string>(4);
			zoneGreenList.Add("Zone5");
			zoneGreenList.Add("Zone7");
			zoneGreenList.Add("Zone8");
			zoneGreenList.Add("Zone9");

			//setYellowList
			zoneYellowList = new List<string>(6);
			zoneYellowList.Add("Zone1");
			zoneYellowList.Add("Zone2");
			zoneYellowList.Add("Zone3");
			zoneYellowList.Add("Zone4");
			zoneYellowList.Add("Zone10");
			zoneYellowList.Add("Zone11");
			
			//setRedList
			zoneRedList = new List<string>(3);
			zoneRedList.Add("Zone12");
			zoneRedList.Add("Zone13");
			zoneRedList.Add("Zone14");
			break;
		case "Zone7":
			cleanAllZoneLists();

			//setGreenList
			zoneGreenList = new List<string>(5);
			zoneGreenList.Add("Zone3");
			zoneGreenList.Add("Zone4");
			zoneGreenList.Add("Zone6");
			zoneGreenList.Add("Zone9");
			zoneGreenList.Add("Zone10");

			//setYellowList
			zoneYellowList = new List<string>(6);
			zoneYellowList.Add("Zone1");
			zoneYellowList.Add("Zone5");
			zoneYellowList.Add("Zone8");
			zoneYellowList.Add("Zone11");
			zoneYellowList.Add("Zone13");
			zoneYellowList.Add("Zone14");
			
			//setRedList
			zoneRedList = new List<string>(2);
			zoneRedList.Add("Zone2");
			zoneRedList.Add("Zone12");
			break;
		case "Zone8":
			cleanAllZoneLists();

			//setGreenList
			zoneGreenList = new List<string>(2);
			zoneGreenList.Add("Zone6");
			zoneGreenList.Add("Zone9");

			//setYellowList
			zoneYellowList = new List<string>(4);
			zoneYellowList.Add("Zone5");
			zoneYellowList.Add("Zone7");
			zoneYellowList.Add("Zone10");
			zoneYellowList.Add("Zone11");
			
			//setRedList
			zoneRedList = new List<string>(7);
			zoneRedList.Add("Zone1");
			zoneRedList.Add("Zone2");
			zoneRedList.Add("Zone3");
			zoneRedList.Add("Zone4");
			zoneRedList.Add("Zone12");
			zoneRedList.Add("Zone13");
			zoneRedList.Add("Zone14");
			break;
		case "Zone9":
			cleanAllZoneLists();

			//setGreenList
			zoneGreenList = new List<string>(5);
			zoneGreenList.Add("Zone6");
			zoneGreenList.Add("Zone7");
			zoneGreenList.Add("Zone8");
			zoneGreenList.Add("Zone10");
			zoneGreenList.Add("Zone11");

			//setYellowList
			zoneYellowList = new List<string>(6);
			zoneYellowList.Add("Zone3");
			zoneYellowList.Add("Zone4");
			zoneYellowList.Add("Zone5");
			zoneYellowList.Add("Zone12");
			zoneYellowList.Add("Zone13");
			zoneYellowList.Add("Zone14");
			
			//setRedList
			zoneRedList = new List<string>(3);
			zoneRedList.Add("Zone1");
			zoneRedList.Add("Zone2");
			zoneRedList.Add("Zone13");
			break;
		case "Zone10":
			cleanAllZoneLists();

			//setGreenList
			zoneGreenList = new List<string>(5);
			zoneGreenList.Add("Zone7");
			zoneGreenList.Add("Zone9");
			zoneGreenList.Add("Zone11");
			zoneGreenList.Add("Zone13");
			zoneGreenList.Add("Zone14");

			//setYellowList
			zoneYellowList = new List<string>(5);
			zoneYellowList.Add("Zone3");
			zoneYellowList.Add("Zone4");
			zoneYellowList.Add("Zone6");
			zoneYellowList.Add("Zone8");
			zoneYellowList.Add("Zone12");
			
			//setRedList
			zoneRedList = new List<string>(3);
			zoneRedList.Add("Zone1");
			zoneRedList.Add("Zone5");
			zoneRedList.Add("Zone15");
			break;
		case "Zone11":
			cleanAllZoneLists();
			
			//setGreenList
			zoneGreenList = new List<string>(4);
			zoneGreenList.Add("Zone9");
			zoneGreenList.Add("Zone10");
			zoneGreenList.Add("Zone12");
			zoneGreenList.Add("Zone13");
			
			//setYellowList
			zoneYellowList = new List<string>(5);
			zoneYellowList.Add("Zone6");
			zoneYellowList.Add("Zone7");
			zoneYellowList.Add("Zone8");
			zoneYellowList.Add("Zone14");
			zoneYellowList.Add("Zone15");

			
			//setRedList
			zoneRedList = new List<string>(4);
			zoneRedList.Add("Zone1");
			zoneRedList.Add("Zone3");
			zoneRedList.Add("Zone4");
			zoneRedList.Add("Zone5");
			break;
		case "Zone12":
			cleanAllZoneLists();
			
			//setGreenList
			zoneGreenList = new List<string>(3);
			zoneGreenList.Add("Zone11");
			zoneGreenList.Add("Zone13");
			zoneGreenList.Add("Zone15");
			
			//setYellowList
			zoneYellowList = new List<string>(3);
			zoneYellowList.Add("Zone9");
			zoneYellowList.Add("Zone10");
			zoneYellowList.Add("Zone14");
			
			//setRedList
			zoneRedList = new List<string>(3);
			zoneRedList.Add("Zone6");
			zoneRedList.Add("Zone7");
			zoneRedList.Add("Zone8");
			break;
		case "Zone13":
			cleanAllZoneLists();
			
			//setGreenList
			zoneGreenList = new List<string>(4);
			zoneGreenList.Add("Zone10");
			zoneGreenList.Add("Zone11");
			zoneGreenList.Add("Zone12");
			zoneGreenList.Add("Zone14");

			//setYellowList
			zoneYellowList = new List<string>(3);
			zoneYellowList.Add("Zone7");
			zoneYellowList.Add("Zone9");
			zoneYellowList.Add("Zone15");
			
			//setRedList
			zoneRedList = new List<string>(4);
			zoneRedList.Add("Zone3");
			zoneRedList.Add("Zone4");
			zoneRedList.Add("Zone6");
			zoneRedList.Add("Zone8");
			break;
		case "Zone14":
			cleanAllZoneLists();
			
			//setGreenList
			zoneGreenList = new List<string>(2);
			zoneGreenList.Add("Zone10");
			zoneGreenList.Add("Zone13");

			//setYellowList
			zoneYellowList = new List<string>(5);
			zoneYellowList.Add("Zone7");
			zoneYellowList.Add("Zone9");
			zoneYellowList.Add("Zone11");
			zoneYellowList.Add("Zone12");
			zoneYellowList.Add("Zone15");
			
			//setRedList
			zoneRedList = new List<string>(5);
			zoneRedList.Add("Zone3");
			zoneRedList.Add("Zone4");
			zoneRedList.Add("Zone6");
			zoneRedList.Add("Zone8");
			zoneRedList.Add("Zone15");
			break;
		case "Zone15":
			cleanAllZoneLists();
			
			//setGreenList
			zoneGreenList = new List<string>(1);
			zoneGreenList.Add("Zone12");
			
			//setYellowList
			zoneYellowList = new List<string>(4);
			zoneYellowList.Add("Zone10");
			zoneYellowList.Add("Zone11");
			zoneYellowList.Add("Zone13");
			zoneYellowList.Add("Zone14");
			
			//setRedList
			zoneRedList = new List<string>(3);
			zoneRedList.Add("Zone9");
			zoneRedList.Add("Zone10");
			zoneRedList.Add("Zone14");
			break;
		default:
			break;
		}
	}
}