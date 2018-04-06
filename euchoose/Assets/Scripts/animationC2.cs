using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationC2 : MonoBehaviour {

	public Animator anim;

	void Start () {

		anim = GetComponent<Animator> ();

	}

	void Update () {
			
		if (office.reactie2 == true) {
			anim.Play ("Noroc|NorocAction", -1, 0f);
			office.reactie2 = false;
		}

	}
}
