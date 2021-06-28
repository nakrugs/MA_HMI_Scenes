using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyTown {

	public class MenuCtrl : MonoBehaviour {

		GameObject mainCamera;
		private Vector3 cameraPos = new Vector3 (170.0f, 60.0f, -170.0f);
		private Vector3 cameraAng = new Vector3 (5.0f, 0.0f, 0.0f);
		private float directionalLightBright = 1.0f;
		private float roomLightBright = 0.0f;
		private float doorLightBright = 0.0f;
		private float roadLightBright = 0.0f;

		// Use this for initialization
		void Start () {
			mainCamera = GameObject.Find ("Main Camera");
			mainCamera.transform.position = cameraPos;
			mainCamera.transform.rotation = Quaternion.Euler (cameraAng);
			DayMode (true);
		}

		void OnGUI () {
			GUI.Box (new Rect (30, 20, 120, 80), "Brightness");
			if (GUI.Button (new Rect (40, 45, 100, 20), "Daytime")) {
				DayMode (true);
			}
			if (GUI.Button (new Rect (40, 70, 100, 20), "Night")) {
				DayMode (false);
			}
		}

		// Update is called once per frame
		void Update () {

		}

		void DayMode (bool mode) {
			if (mode == true) {
				directionalLightBright = 1.0f;
				roomLightBright = 0.0f;
				doorLightBright = 0.0f;
				roadLightBright = 0.0f;
			} else {
				directionalLightBright = 0.0f;
				roomLightBright = 0.7f;
				doorLightBright = 0.7f;
				roadLightBright = 0.7f;
			}

			// Directional light Change
			GameObject directionalLight = GameObject.Find ("Directional light");
			Color lightColor = directionalLight.GetComponent<Light>().color;
			lightColor.r = directionalLightBright;
			lightColor.g = directionalLightBright;
			lightColor.b = directionalLightBright;
			directionalLight.GetComponent<Light>().color = lightColor;

			// Window Change
			GameObject[] windowList = GameObject.FindGameObjectsWithTag ("HouseWindow");
			foreach (GameObject window in windowList) {
				//Debug.Log ("HouseWindow");
				MeshRenderer meshRenderer = window.GetComponent<MeshRenderer>();
				meshRenderer.material.EnableKeyword ("_EMISSION");
				meshRenderer.material.SetColor ("_EmissionColor", new Color (roomLightBright, roomLightBright, roomLightBright));
				meshRenderer.UpdateGIMaterials ();
			}

			// Lamp Change
			GameObject[] DoorList = GameObject.FindGameObjectsWithTag ("DoorLamp");
			foreach (GameObject door in DoorList) {
				//Debug.Log ("HouseWindow");
				MeshRenderer meshRenderer = door.GetComponent<MeshRenderer>();
				meshRenderer.material.EnableKeyword ("_EMISSION");
				meshRenderer.material.SetColor ("_EmissionColor", new Color (doorLightBright, doorLightBright, doorLightBright));
				meshRenderer.UpdateGIMaterials();
			}

			// Street Lamp Change
			GameObject[] lampList = GameObject.FindGameObjectsWithTag ("LampLens");
			foreach (GameObject lamp in lampList) {
				//Debug.Log ("LampLens");
				MeshRenderer meshRenderer = lamp.GetComponent<MeshRenderer>();
				meshRenderer.material.EnableKeyword ("_EMISSION");
				meshRenderer.material.SetColor ("_EmissionColor", new Color (roadLightBright, roadLightBright, roadLightBright));
				meshRenderer.UpdateGIMaterials ();
			}
			GameObject[] lensList = GameObject.FindGameObjectsWithTag ("StreetLamp");
			foreach (GameObject lens in lensList) {
				//Debug.Log ("StreetLamp");
				Color lensColor = lens.GetComponent<Light>().color;
				lensColor.r = roadLightBright;
				lensColor.g = roadLightBright;
				lensColor.b = roadLightBright;
				lens.GetComponent<Light>().color = lensColor;
			}
		}
	}
}
