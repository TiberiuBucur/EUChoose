using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    public Camera mainCam;
    private Quaternion targetRotation1 = Quaternion.Euler(30f, 30f, 0f);
    private Quaternion targetRotation2 = Quaternion.Euler(30f, 140f, 0f);
    private Quaternion targetRotation3 = Quaternion.Euler(30f, 90f, 0f);
	private Quaternion targetRotation4 = Quaternion.Euler(32f, 90f, 0f);
	public Vector3 targetPosition1;
	public Vector3 targetPosition2;
	public GameObject eCanvas;
	public static GameObject eCanvasStatic;

    void Awake()
    {
        mainCam = Camera.main;
    }

	void Start(){
		eCanvas.SetActive (false);
		eCanvasStatic = eCanvas;
	}

	void Update()
    {
		if (Input.GetKeyDown (KeyCode.A))
			StartCoroutine (LerpFromTo (mainCam.transform.position, targetPosition1, mainCam.transform.rotation, targetRotation1, 1f));
		else if (Input.GetKeyDown (KeyCode.D))
			StartCoroutine (LerpFromTo (mainCam.transform.position, targetPosition1, mainCam.transform.rotation, targetRotation2, 1f));
		else if (Input.GetKeyDown (KeyCode.S))
			StartCoroutine (LerpFromTo (mainCam.transform.position, targetPosition1, mainCam.transform.rotation, targetRotation3, 1f));
		else if (Input.GetKeyDown (KeyCode.W))
			StartCoroutine (LerpFromTo2 (mainCam.transform.position, targetPosition2, mainCam.transform.rotation, targetRotation4, 1f));
		

    }
    IEnumerator LerpFromTo(Vector3 pos1,Vector3 pos2, Quaternion rot1,Quaternion rot2, float duration)
    {
		eCanvas.SetActive (false);
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
		eCanvas.SetActive (true);
	}
}
