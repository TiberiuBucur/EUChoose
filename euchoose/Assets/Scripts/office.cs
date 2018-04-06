using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class office : MonoBehaviour {

	public Camera mainCam;
	private Vector3 targetPosition1 = new Vector3 (6f, 3.2f, 0.1f);
	private Quaternion targetRotation1 = Quaternion.Euler(15f, 50f, 0f);

	private Vector3 targetPosition2 = new Vector3 (6f, 3.2f, 5f);
	private Quaternion targetRotation2 = Quaternion.Euler(15f, 0f, 0f);

	private Quaternion targetRotation3 = Quaternion.Euler(30f, 0f, 0f);

	public GameObject sferaTiming1;
	public GameObject cubTiming1;
	private float translation2;

	public GameObject om1;
	public GameObject om2;

	public static bool reactie1;
	public static bool reactie2;

	public GameObject panouInfo;

	void Start () {
		mainCam = Camera.main;
		reactie1 = false;
		reactie2 = false;
	}


	void Update () {

		translation2 = Time.deltaTime * 1;

		sferaTiming1.transform.Translate (0, 0, -translation2);

	}

	IEnumerator LerpFromTo(Vector3 pos1,Vector3 pos2, Quaternion rot1,Quaternion rot2, float duration)
	{
		for(float t=0f;t<duration;t+=Time.deltaTime)
		{
			mainCam.transform.position = Vector3.Lerp(pos1, pos2, t / duration);
			mainCam.transform.rotation = Quaternion.Slerp(rot1, rot2, t / duration);
			yield return 0;
		}
		mainCam.transform.position = pos2;
		mainCam.transform.rotation = rot2;

	}

	IEnumerator LerpFromTo2(Vector3 pos1,Vector3 pos2, Quaternion rot1,Quaternion rot2, float duration)
	{
		for(float t=0f;t<duration;t+=Time.deltaTime)
		{
			mainCam.transform.position = Vector3.Lerp(pos1, pos2, t / duration);
			mainCam.transform.rotation = Quaternion.Slerp(rot1, rot2, t / duration);
			yield return 0;
		}
		mainCam.transform.position = pos2;
		mainCam.transform.rotation = rot2;
		om1.SetActive (true);
		reactie2 = true;
	}


	void OnTriggerEnter (Collider other){
		if (other.gameObject.CompareTag ("cub1")) {
			StartCoroutine (LerpFromTo (mainCam.transform.position, targetPosition1, mainCam.transform.rotation, targetRotation1, 1.5f));

		}
		if (other.gameObject.CompareTag ("cub2")) {
			StartCoroutine (LerpFromTo2 (mainCam.transform.position, targetPosition2, mainCam.transform.rotation, targetRotation2, 2f));

		}

		if (other.gameObject.CompareTag ("cub3")) {
			panouInfo.SetActive (true);
		}

	}

}
