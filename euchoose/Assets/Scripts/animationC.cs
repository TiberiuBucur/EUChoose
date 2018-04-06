using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationC : MonoBehaviour {

    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

	void Update () {

        if (Input.GetMouseButton(0))
        {
            int n = Random.Range(0, 5);

			if (n == 0 || n==2)
            {
                anim.Play("Parlamentar|ParlamentarAction001", -1, 0f);
            }

			if (n==1 || n == 4)
            {
                anim.Play("Parlamentar|ParlamentarAction002", -1, 0f);
            }

			if (n == 3) {
				anim.Play ("Parlamentar|ParlamentarAction006", -1, 0f);
			}
        }
    }

}




