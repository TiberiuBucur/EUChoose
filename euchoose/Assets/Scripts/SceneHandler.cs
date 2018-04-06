using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneHandler : MonoBehaviour {
    public static int happiness, economy, cohesion, nrq, newsno;
    public Text happinesst, economyt, cohesiont;
    public static GameObject[] activenews = new GameObject[16];
	public GameObject newsArchiveNS;
	public static GameObject newsArchive;
    void Start()
    {
		Yes.naPos [0] = Yes.naPos1;
		Yes.naPos [1] = Yes.naPos2;
		Yes.naPos [2] = Yes.naPos3;
		Yes.naPos [3] = Yes.naPos4;
		Yes.naPos [4] = Yes.naPos5;
		Yes.naPos [5] = Yes.naPos6;
		Yes.naPos [6] = Yes.naPos7;
		Yes.naPos [7] = Yes.naPos8;
		Yes.naPos [8] = Yes.naPos9;
		Yes.naPos [9] = Yes.naPos10;
		Yes.naPos [10] = Yes.naPos11;
		Yes.naPos [11] = Yes.naPos12;
		Yes.naPos [12] = Yes.naPos13;
		Yes.naPos [13] = Yes.naPos14;
		Yes.naPos [14] = Yes.naPos15;
		nrq = newsno = 0;
		newsArchive = newsArchiveNS;
        happiness = economy = cohesion = 50;
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
            SceneManager.LoadScene(0);
    }
}
