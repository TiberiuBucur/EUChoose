using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Yes : MonoBehaviour
{
	public GameObject panouq1, panouq2, panouq3, panouq4, panouq5, NextVotebutton, gameover_economy, gameover_happiness, gameover_cohesion, panouq6, statsButton, newsButton, panouq7, panouq8, panouq9, panouq10, hintbutton;
	public GameObject panouq11, panouq12, panouq13, panouq14, panouq15;
	private Vector3 pos1 = new Vector3 (513f, 484f, 0f);
    public GameObject helptext;
    private Vector3 auxilliary = new Vector3(0f, -100f, 0f);
	public GameObject yesq1, yesq2, yesq3, yesq4, yesq5, yesq6, yesq7, yesq8, yesq9, yesq10, yesq11, yesq12, yesq13, yesq14, yesq15, panoustiri, winpanel;
	private GameObject x;
    private bool ok = true;

	public static Vector3 naPos1 = new Vector3 (320f, 520f, 0f);
	public static Vector3 naPos2 = new Vector3 (320f, 440f, 0f);
	public static Vector3 naPos3 = new Vector3 (320f, 360f, 0f);
	public static Vector3 naPos4 = new Vector3 (320f, 280f, 0f);
	public static Vector3 naPos5 = new Vector3 (320f, 200f, 0f);
	public static Vector3 naPos6 = new Vector3 (700f, 520f, 0f);
	public static Vector3 naPos7 = new Vector3 (700f, 440f, 0f);
	public static Vector3 naPos8 = new Vector3 (700f, 360f, 0f);
	public static Vector3 naPos9 = new Vector3 (700f, 280f, 0f);
	public static Vector3 naPos10 = new Vector3 (700f, 200f, 0f);
	public static Vector3 naPos11 = new Vector3 (320f, 520f, 0f);
	public static Vector3 naPos12 = new Vector3 (320f, 440f, 0f);
	public static Vector3 naPos13 = new Vector3 (320f, 360f, 0f);
	public static Vector3 naPos14 = new Vector3 (320f, 280f, 0f);
	public static Vector3 naPos15 = new Vector3 (320f, 200f, 0f);


	public static Vector3[] naPos = new Vector3[15];

	void Awake(){
		declarari.yesq [0] = yesq1;
		declarari.yesq [1] = yesq2;
		declarari.yesq [2] = yesq3;
		declarari.yesq [3] = yesq4;
		declarari.yesq [4] = yesq5;
		declarari.yesq [5] = yesq6;
		declarari.yesq [6] = yesq7;
		declarari.yesq [7] = yesq8;
		declarari.yesq [8] = yesq9;
		declarari.yesq [9] = yesq10;
		declarari.yesq [10] = yesq11;
		declarari.yesq [11] = yesq12;
		declarari.yesq [12] = yesq13;
		declarari.yesq [13] = yesq14;
		declarari.yesq [14] = yesq15;


	}

	public void SpawnNewsArchive (int poz){
		x = Instantiate (declarari.yesq [poz], naPos [poz], Quaternion.identity) as GameObject;
		print (poz);
		x.transform.SetParent (SceneHandler.newsArchive.transform);
		//print (x.transform.localScale);
		x.transform.localScale -= new Vector3 (0.3f, 0.3f, 0f);
	}

    public void ChangeStats()
    {
        switch(SceneHandler.nrq)
        {
            case 1:
                {
                    SceneHandler.economy -= 12;
                    SceneHandler.cohesion += 5;
                    SceneHandler.happiness += 10;
                    panouq1.SetActive(false);
                    SceneHandler.activenews[++SceneHandler.newsno] = Instantiate(yesq1, pos1, Quaternion.identity) as GameObject;
                    SceneHandler.activenews[SceneHandler.newsno].transform.SetParent(panoustiri.transform);
					break;
                }
            case 2:
                {
                    SceneHandler.economy -= 15;
                    SceneHandler.cohesion += 10;
                    SceneHandler.happiness += 18;
                    panouq2.SetActive(false);
                    SceneHandler.activenews[++SceneHandler.newsno] = Instantiate(yesq2, pos1, Quaternion.identity) as GameObject;
                    SceneHandler.activenews[SceneHandler.newsno].transform.SetParent(panoustiri.transform);
                    SceneHandler.activenews[SceneHandler.newsno - 1].transform.position += auxilliary;
                    break;
                }
            case 3:
                {
                    SceneHandler.economy -= 20;
                    SceneHandler.cohesion += 9;
                    SceneHandler.happiness += 18;
                    panouq3.SetActive(false);
                    SceneHandler.activenews[++SceneHandler.newsno] = Instantiate(yesq3, pos1, Quaternion.identity) as GameObject;
                    SceneHandler.activenews[SceneHandler.newsno].transform.SetParent(panoustiri.transform);
                    for (int i = SceneHandler.newsno - 2; i < SceneHandler.newsno; i++)
                        SceneHandler.activenews[i].transform.position += auxilliary;
                    break;
                }
            case 4:
                {
                    SceneHandler.economy -= 12;
                    SceneHandler.cohesion += 13;
                    SceneHandler.happiness += 4;
                    panouq4.SetActive(false);
                    SceneHandler.activenews[++SceneHandler.newsno] = Instantiate(yesq4, pos1, Quaternion.identity) as GameObject;
                    SceneHandler.activenews[SceneHandler.newsno].transform.SetParent(panoustiri.transform);
                    for (int i = SceneHandler.newsno - 2; i < SceneHandler.newsno; i++)
                        SceneHandler.activenews[i].transform.position += auxilliary;
                    SceneHandler.activenews[SceneHandler.newsno - 3].SetActive(false);
                    break;
                }
            case 5:
                {
                    SceneHandler.economy -= 10;
                    SceneHandler.cohesion += 7;
                    SceneHandler.happiness += 20;
                    panouq5.SetActive(false);
                    SceneHandler.activenews[++SceneHandler.newsno] = Instantiate(yesq5, pos1, Quaternion.identity) as GameObject;
                    SceneHandler.activenews[SceneHandler.newsno].transform.SetParent(panoustiri.transform);
                    for (int i = SceneHandler.newsno - 2; i < SceneHandler.newsno; i++)
                        SceneHandler.activenews[i].transform.position += auxilliary;
                    SceneHandler.activenews[SceneHandler.newsno - 3].SetActive(false);
                    break;
                }
			case 6:
				{
					SceneHandler.economy -= 7;
					SceneHandler.cohesion -= 5;
					SceneHandler.happiness -= 8;
					panouq6.SetActive(false);
                    SceneHandler.activenews[++SceneHandler.newsno] = Instantiate(yesq6, pos1, Quaternion.identity) as GameObject;
                    SceneHandler.activenews[SceneHandler.newsno].transform.SetParent(panoustiri.transform);
                    for (int i = SceneHandler.newsno - 2; i < SceneHandler.newsno; i++)
                        SceneHandler.activenews[i].transform.position += auxilliary;
                    SceneHandler.activenews[SceneHandler.newsno - 3].SetActive(false);
                    break;
				}
            case 7:
                {
                    SceneHandler.economy -= 10;
                    SceneHandler.cohesion += 10;
                    SceneHandler.happiness += 15;
                    panouq7.SetActive(false);
                    SceneHandler.activenews[++SceneHandler.newsno] = Instantiate(yesq7, pos1, Quaternion.identity) as GameObject;
                    SceneHandler.activenews[SceneHandler.newsno].transform.SetParent(panoustiri.transform);
                    for (int i = SceneHandler.newsno - 2; i < SceneHandler.newsno; i++)
                        SceneHandler.activenews[i].transform.position += auxilliary;
                    SceneHandler.activenews[SceneHandler.newsno - 3].SetActive(false);
                    break;

                }
            case 8:
                {
                    SceneHandler.economy += 7;
                    SceneHandler.cohesion -= 3;
                    SceneHandler.happiness -= 10;
                    panouq8.SetActive(false);
                    SceneHandler.activenews[++SceneHandler.newsno] = Instantiate(yesq8, pos1, Quaternion.identity) as GameObject;
                    SceneHandler.activenews[SceneHandler.newsno].transform.SetParent(panoustiri.transform);
                    for (int i = SceneHandler.newsno - 2; i < SceneHandler.newsno; i++)
                        SceneHandler.activenews[i].transform.position += auxilliary;
                    SceneHandler.activenews[SceneHandler.newsno - 3].SetActive(false);
                    break;
                }
            case 9:
                {
                    SceneHandler.economy += 15;
                    SceneHandler.cohesion -= 5;
                    SceneHandler.happiness -= 15;
                    panouq9.SetActive(false);
                    SceneHandler.activenews[++SceneHandler.newsno] = Instantiate(yesq9, pos1, Quaternion.identity) as GameObject;
                    SceneHandler.activenews[SceneHandler.newsno].transform.SetParent(panoustiri.transform);
                    for (int i = SceneHandler.newsno - 2; i < SceneHandler.newsno; i++)
                        SceneHandler.activenews[i].transform.position += auxilliary;
                    SceneHandler.activenews[SceneHandler.newsno - 3].SetActive(false);
                    break;
                }
			case 10:
				{
					SceneHandler.economy += 15;
					SceneHandler.cohesion -= 5;
					SceneHandler.happiness -= 15;
					panouq10.SetActive(false);
					SceneHandler.activenews[++SceneHandler.newsno] = Instantiate(yesq10, pos1, Quaternion.identity) as GameObject;
					SceneHandler.activenews[SceneHandler.newsno].transform.SetParent(panoustiri.transform);
					for (int i = SceneHandler.newsno - 2; i < SceneHandler.newsno; i++)
						SceneHandler.activenews[i].transform.position += auxilliary;
					SceneHandler.activenews[SceneHandler.newsno - 3].SetActive(false);
					break;
				}
			case 11:
				{
					SceneHandler.economy += 15;
					SceneHandler.cohesion -= 5;
					SceneHandler.happiness -= 15;
					panouq11.SetActive(false);
					SceneHandler.activenews[++SceneHandler.newsno] = Instantiate(yesq11, pos1, Quaternion.identity) as GameObject;
					SceneHandler.activenews[SceneHandler.newsno].transform.SetParent(panoustiri.transform);
					for (int i = SceneHandler.newsno - 2; i < SceneHandler.newsno; i++)
						SceneHandler.activenews[i].transform.position += auxilliary;
					SceneHandler.activenews[SceneHandler.newsno - 3].SetActive(false);
					break;
				}
			case 12:
				{
					SceneHandler.economy += 15;
					SceneHandler.cohesion -= 5;
					SceneHandler.happiness -= 15;
					panouq12.SetActive(false);
					SceneHandler.activenews[++SceneHandler.newsno] = Instantiate(yesq12, pos1, Quaternion.identity) as GameObject;
					SceneHandler.activenews[SceneHandler.newsno].transform.SetParent(panoustiri.transform);
					for (int i = SceneHandler.newsno - 2; i < SceneHandler.newsno; i++)
						SceneHandler.activenews[i].transform.position += auxilliary;
					SceneHandler.activenews[SceneHandler.newsno - 3].SetActive(false);
					break;
				}
			case 13:
				{
					SceneHandler.economy += 15;
					SceneHandler.cohesion -= 5;
					SceneHandler.happiness -= 15;
					panouq13.SetActive(false);
					SceneHandler.activenews[++SceneHandler.newsno] = Instantiate(yesq13, pos1, Quaternion.identity) as GameObject;
					SceneHandler.activenews[SceneHandler.newsno].transform.SetParent(panoustiri.transform);
					for (int i = SceneHandler.newsno - 2; i < SceneHandler.newsno; i++)
						SceneHandler.activenews[i].transform.position += auxilliary;
					SceneHandler.activenews[SceneHandler.newsno - 3].SetActive(false);
					break;
				}
			case 14:
				{
					SceneHandler.economy += 15;
					SceneHandler.cohesion -= 5;
					SceneHandler.happiness -= 15;
					panouq14.SetActive(false);
					SceneHandler.activenews[++SceneHandler.newsno] = Instantiate(yesq14, pos1, Quaternion.identity) as GameObject;
					SceneHandler.activenews[SceneHandler.newsno].transform.SetParent(panoustiri.transform);
					for (int i = SceneHandler.newsno - 2; i < SceneHandler.newsno; i++)
						SceneHandler.activenews[i].transform.position += auxilliary;
					SceneHandler.activenews[SceneHandler.newsno - 3].SetActive(false);
					break;
				}
	       	default:
                {
                    SceneHandler.economy -= 10;
                    SceneHandler.cohesion += 10;
                    SceneHandler.happiness += 20;
                    panouq15.SetActive(false);
                    SceneHandler.activenews[++SceneHandler.newsno] = Instantiate(yesq15, pos1, Quaternion.identity) as GameObject;
                    SceneHandler.activenews[SceneHandler.newsno].transform.SetParent(panoustiri.transform);
                    for (int i = SceneHandler.newsno - 2; i < SceneHandler.newsno; i++)
                        SceneHandler.activenews[i].transform.position += auxilliary;
                    SceneHandler.activenews[SceneHandler.newsno - 3].SetActive(false);
                    break;
                }
        }
        SpawnNewsArchive(SceneHandler.nrq-1);
        statsButton.SetActive (true);
        helptext.SetActive(false);
        hintbutton.SetActive(false);
        NextVotebutton.SetActive(true);
        newsButton.SetActive (true);
    }
    public void CheckStats()
    {
        if (SceneHandler.economy <= 10)
        {
            if (SceneHandler.economy < 0)
                SceneHandler.economy = 0;
            gameover_economy.SetActive(true);
            NextVotebutton.SetActive(false);
			statsButton.SetActive(false);
            ok = false;
        }
        else if (SceneHandler.economy > 100)
            SceneHandler.economy = 100;
        if (SceneHandler.happiness <= 10)
        {
            if (SceneHandler.happiness < 0)
                SceneHandler.happiness = 0;
            gameover_happiness.SetActive(true);
            NextVotebutton.SetActive(false);
			statsButton.SetActive(false);
            ok = false;
        }
        else if (SceneHandler.happiness > 100)
            SceneHandler.happiness = 100;
        if (SceneHandler.cohesion <= 10)
        {
            if (SceneHandler.cohesion < 0)
                SceneHandler.cohesion = 0;
            gameover_cohesion.SetActive(true);
            NextVotebutton.SetActive(false);
			statsButton.SetActive(false);
            ok = false;
        }
        else if (SceneHandler.cohesion > 100)
            SceneHandler.cohesion = 100;
        if(ok && SceneHandler.nrq==15)
        {
            NextVotebutton.SetActive(false);
            statsButton.SetActive(false);
            winpanel.SetActive(true);
        }
    }
}
