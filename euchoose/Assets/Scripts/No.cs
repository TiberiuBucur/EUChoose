using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class No : MonoBehaviour
{
    public GameObject panouq1, panouq2, panouq3, panouq4, panouq5, NextVotebutton, gameover_economy, gameover_happiness, gameover_cohesion, panouq6, statsButton, newsButton, panouq7, panouq8, panouq9, panouq10, hintbutton;
	public GameObject panouq11, panouq12, panouq13, panouq14, panouq15;
	private Vector3 pos1 = new Vector3 (513f, 484f, 0f);
    private Vector3 auxilliary = new Vector3(0f, -100f, 0f);
	public GameObject noq1, noq2, noq3, noq4, noq5, noq6, noq7, noq8, noq9, noq10, panoustiri, x, winpanel, helptext;
	public GameObject noq11, noq12, noq13, noq14, noq15;
    private bool ok = true;

	void Awake(){
		declarari.noq [0] = noq1;
		declarari.noq [1] = noq2;
		declarari.noq [2] = noq3;
		declarari.noq [3] = noq4;
		declarari.noq [4] = noq5;
		declarari.noq [5] = noq6;
		declarari.noq [6] = noq7;
		declarari.noq [7] = noq8;
		declarari.noq [8] = noq9;
		declarari.noq [9] = noq10;
		declarari.noq [10] = noq11;
		declarari.noq [11] = noq12;
		declarari.noq [12] = noq13;
		declarari.noq [13] = noq14;
		declarari.noq [14] = noq15;
	}

	public void SpawnNewsArchive (int poz){
		x = Instantiate (declarari.noq [poz], Yes.naPos [poz], Quaternion.identity) as GameObject;
		x.transform.SetParent (SceneHandler.newsArchive.transform);
		x.transform.localScale -= new Vector3 (0.4f, 0.4f, 0f);
	}

    public void ChangeStats()
    {
        switch (SceneHandler.nrq)
        {
            case 1:
                {
                    SceneHandler.economy += 5;
                    SceneHandler.cohesion -= 7;
                    SceneHandler.happiness -= 15;
                    panouq1.SetActive(false);
                    SceneHandler.activenews[++SceneHandler.newsno] = Instantiate(noq1, pos1, Quaternion.identity) as GameObject;
                    SceneHandler.activenews[SceneHandler.newsno].transform.SetParent(panoustiri.transform);
                    break;
                }
            case 2:
                {
                    SceneHandler.economy += 5;
                    SceneHandler.cohesion -= 5;
                    SceneHandler.happiness -= 20;
                    panouq2.SetActive(false);
                    SceneHandler.activenews[++SceneHandler.newsno] = Instantiate(noq2, pos1, Quaternion.identity) as GameObject;
                    SceneHandler.activenews[SceneHandler.newsno].transform.SetParent(panoustiri.transform);
                    SceneHandler.activenews[SceneHandler.newsno - 1].transform.position += auxilliary;
                    break;
                }
            case 3:
                {
                    SceneHandler.economy += 15;
                    SceneHandler.cohesion -= 5;
                    SceneHandler.happiness -= 10;
                    panouq3.SetActive(false);
                    SceneHandler.activenews[++SceneHandler.newsno] = Instantiate(noq3, pos1, Quaternion.identity) as GameObject;
                    SceneHandler.activenews[SceneHandler.newsno].transform.SetParent(panoustiri.transform);
                    for (int i = SceneHandler.newsno - 2; i < SceneHandler.newsno; i++)
                        SceneHandler.activenews[i].transform.position += auxilliary;
                    break;
                }
            case 4:
                {
                    SceneHandler.economy -= 5;
                    SceneHandler.cohesion -= 13;
                    SceneHandler.happiness -= 4;
                    panouq4.SetActive(false);
                    SceneHandler.activenews[++SceneHandler.newsno] = Instantiate(noq4, pos1, Quaternion.identity) as GameObject;
                    SceneHandler.activenews[SceneHandler.newsno].transform.SetParent(panoustiri.transform);
                    for (int i = SceneHandler.newsno - 2; i < SceneHandler.newsno; i++)
                        SceneHandler.activenews[i].transform.position += auxilliary;
                    SceneHandler.activenews[SceneHandler.newsno - 3].SetActive(false);
                    break;
                }
            case 5:
                {
                    SceneHandler.economy += 5;
                    SceneHandler.cohesion -= 7;
                    SceneHandler.happiness -= 20;
                    panouq5.SetActive(false);
                    SceneHandler.activenews[++SceneHandler.newsno] = Instantiate(noq5, pos1, Quaternion.identity) as GameObject;
                    SceneHandler.activenews[SceneHandler.newsno].transform.SetParent(panoustiri.transform);
                    for (int i = SceneHandler.newsno - 2; i < SceneHandler.newsno; i++)
                        SceneHandler.activenews[i].transform.position += auxilliary;
                    SceneHandler.activenews[SceneHandler.newsno - 3].SetActive(false);
                    break;
                }
			case 6:
				{
					SceneHandler.economy += 3;
					SceneHandler.cohesion += 4;
					SceneHandler.happiness += 2;
					panouq6.SetActive(false);
                    SceneHandler.activenews[++SceneHandler.newsno] = Instantiate(noq6, pos1, Quaternion.identity) as GameObject;
                    SceneHandler.activenews[SceneHandler.newsno].transform.SetParent(panoustiri.transform);
                    for (int i = SceneHandler.newsno - 2; i < SceneHandler.newsno; i++)
                        SceneHandler.activenews[i].transform.position += auxilliary;
                    SceneHandler.activenews[SceneHandler.newsno - 3].SetActive(false);
                    break;
				}
            case 7:
                {
                    SceneHandler.economy += 3;
                    SceneHandler.cohesion -= 8;
                    SceneHandler.happiness -= 13;
                    panouq7.SetActive(false);
                    SceneHandler.activenews[++SceneHandler.newsno] = Instantiate(noq7, pos1, Quaternion.identity) as GameObject;
                    SceneHandler.activenews[SceneHandler.newsno].transform.SetParent(panoustiri.transform);
                    for (int i = SceneHandler.newsno - 2; i < SceneHandler.newsno; i++)
                        SceneHandler.activenews[i].transform.position += auxilliary;
                    SceneHandler.activenews[SceneHandler.newsno - 3].SetActive(false);
                    break;
                }
            case 8:
                {
                    SceneHandler.economy -= 15;
                    SceneHandler.cohesion += 10;
                    SceneHandler.happiness += 3;
                    panouq8.SetActive(false);
                    SceneHandler.activenews[++SceneHandler.newsno] = Instantiate(noq8, pos1, Quaternion.identity) as GameObject;
                    SceneHandler.activenews[SceneHandler.newsno].transform.SetParent(panoustiri.transform);
                    for (int i = SceneHandler.newsno - 2; i < SceneHandler.newsno; i++)
                        SceneHandler.activenews[i].transform.position += auxilliary;
                    SceneHandler.activenews[SceneHandler.newsno - 3].SetActive(false);
                    break;
                }
            case 9:
                {
                    SceneHandler.economy -= 15;
                    SceneHandler.cohesion += 5;
                    SceneHandler.happiness += 20;
                    panouq9.SetActive(false);
                    SceneHandler.activenews[++SceneHandler.newsno] = Instantiate(noq9, pos1, Quaternion.identity) as GameObject;
                    SceneHandler.activenews[SceneHandler.newsno].transform.SetParent(panoustiri.transform);
                    for (int i = SceneHandler.newsno - 2; i < SceneHandler.newsno; i++)
                        SceneHandler.activenews[i].transform.position += auxilliary;
                    SceneHandler.activenews[SceneHandler.newsno - 3].SetActive(false);
                    break;
                }
			case 10:
				{
					SceneHandler.economy -= 15;
					SceneHandler.cohesion += 5;
					SceneHandler.happiness += 20;
					panouq10.SetActive(false);
					SceneHandler.activenews[++SceneHandler.newsno] = Instantiate(noq10, pos1, Quaternion.identity) as GameObject;
					SceneHandler.activenews[SceneHandler.newsno].transform.SetParent(panoustiri.transform);
					for (int i = SceneHandler.newsno - 2; i < SceneHandler.newsno; i++)
						SceneHandler.activenews[i].transform.position += auxilliary;
					SceneHandler.activenews[SceneHandler.newsno - 3].SetActive(false);
					break;
				}
			case 11:
				{
					SceneHandler.economy -= 15;
					SceneHandler.cohesion += 5;
					SceneHandler.happiness += 20;
					panouq11.SetActive(false);
					SceneHandler.activenews[++SceneHandler.newsno] = Instantiate(noq11, pos1, Quaternion.identity) as GameObject;
					SceneHandler.activenews[SceneHandler.newsno].transform.SetParent(panoustiri.transform);
					for (int i = SceneHandler.newsno - 2; i < SceneHandler.newsno; i++)
						SceneHandler.activenews[i].transform.position += auxilliary;
					SceneHandler.activenews[SceneHandler.newsno - 3].SetActive(false);
					break;
				}
			case 12:
				{
					SceneHandler.economy -= 15;
					SceneHandler.cohesion += 5;
					SceneHandler.happiness += 20;
					panouq12.SetActive(false);
					SceneHandler.activenews[++SceneHandler.newsno] = Instantiate(noq12, pos1, Quaternion.identity) as GameObject;
					SceneHandler.activenews[SceneHandler.newsno].transform.SetParent(panoustiri.transform);
					for (int i = SceneHandler.newsno - 2; i < SceneHandler.newsno; i++)
						SceneHandler.activenews[i].transform.position += auxilliary;
					SceneHandler.activenews[SceneHandler.newsno - 3].SetActive(false);
					break;
				}
			case 13:
				{
					SceneHandler.economy -= 15;
					SceneHandler.cohesion += 5;
					SceneHandler.happiness += 20;
					panouq13.SetActive(false);
					SceneHandler.activenews[++SceneHandler.newsno] = Instantiate(noq13, pos1, Quaternion.identity) as GameObject;
					SceneHandler.activenews[SceneHandler.newsno].transform.SetParent(panoustiri.transform);
					for (int i = SceneHandler.newsno - 2; i < SceneHandler.newsno; i++)
						SceneHandler.activenews[i].transform.position += auxilliary;
					SceneHandler.activenews[SceneHandler.newsno - 3].SetActive(false);
					break;
				}
			case 14:
				{
					SceneHandler.economy -= 15;
					SceneHandler.cohesion += 5;
					SceneHandler.happiness += 20;
					panouq14.SetActive(false);
					SceneHandler.activenews[++SceneHandler.newsno] = Instantiate(noq14, pos1, Quaternion.identity) as GameObject;
					SceneHandler.activenews[SceneHandler.newsno].transform.SetParent(panoustiri.transform);
					for (int i = SceneHandler.newsno - 2; i < SceneHandler.newsno; i++)
						SceneHandler.activenews[i].transform.position += auxilliary;
					SceneHandler.activenews[SceneHandler.newsno - 3].SetActive(false);
					break;
				}
			default:
                {
                    SceneHandler.economy += 10;
                    SceneHandler.cohesion -= 5;
                    SceneHandler.happiness -= 20;
                    panouq15.SetActive(false);
                    SceneHandler.activenews[++SceneHandler.newsno] = Instantiate(noq15, pos1, Quaternion.identity) as GameObject;
                    SceneHandler.activenews[SceneHandler.newsno].transform.SetParent(panoustiri.transform);
                    for (int i = SceneHandler.newsno - 2; i < SceneHandler.newsno; i++)
                        SceneHandler.activenews[i].transform.position += auxilliary;
                    SceneHandler.activenews[SceneHandler.newsno - 3].SetActive(false);
                    break;
                }
        }
		statsButton.SetActive (true);
        SpawnNewsArchive(SceneHandler.nrq-1);
        NextVotebutton.SetActive(true);
        helptext.SetActive(false);
        newsButton.SetActive (true);
        hintbutton.SetActive(false);
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
