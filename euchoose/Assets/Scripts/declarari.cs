using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class declarari : MonoBehaviour {

	public static GameObject[] yesq = new GameObject[16];
	public static GameObject[] noq = new GameObject[16];
	public GameObject[] yesqNS = new GameObject[16];
	public GameObject[] noqNS = new GameObject[16];

	void Awake () {
		for (int i = 0; i <= 15; i++) {
			yesq [i] = yesqNS [i];
			noq [i] = noqNS [i];
		}
	}

}
