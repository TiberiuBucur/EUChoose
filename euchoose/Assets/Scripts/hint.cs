using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hint : MonoBehaviour {

	public GameObject[] panouriHinturi = new GameObject[16];

	public void functionInterior (){
		print (SceneHandler.nrq);
		panouriHinturi [SceneHandler.nrq].SetActive (true);
	}
}
