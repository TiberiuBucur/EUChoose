using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnCompleteNews : MonoBehaviour {

	private Vector3 auxilliary = new Vector3 (513f, 384f, 0f);
	private Vector3 nush = new Vector3 (0f, 0f, 0f);
	private GameObject x;

	public void spawnComplete (GameObject panouDeSpawnat){
		
		x = Instantiate (panouDeSpawnat, nush, Quaternion.identity) as GameObject;
		x.transform.SetParent (CameraController.eCanvasStatic.transform);
		x.transform.position += auxilliary;
	}
}
