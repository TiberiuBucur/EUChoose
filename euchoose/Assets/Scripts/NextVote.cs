using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextVote : MonoBehaviour
{
	public GameObject panouq1, panouq2, panouq3, panouq4, panouq5, NextVotebutton, panouq6, panouq7, panouq8, panouq9, panouq10, hintbutton, panouq11, panouq12, panouq13, panouq14, panouq15;
    public void Incrementnrq()
    {
        SceneHandler.nrq++;
    }
    public void Activare_Panou()
    {
        switch(SceneHandler.nrq)
        {
            case 1:
                {
                    panouq1.SetActive(true);
                    break;
                }
            case 2:
                {
                    panouq1.SetActive(false);
                    panouq2.SetActive(true);
                    break;
                }
            case 3:
                {
                    panouq2.SetActive(false);
                    panouq3.SetActive(true);
                    break;
                }
            case 4:
                {
                    panouq3.SetActive(false);
                    panouq4.SetActive(true);
                    break;
                }
            case 5:
                {
                    panouq4.SetActive(false);
                    panouq5.SetActive(true);
                    break;
                }
			case 6:
				{
					panouq5.SetActive(false);
					panouq6.SetActive(true);
					break;
				}
            case 7:
                {
                    panouq6.SetActive(false);
                    panouq7.SetActive(true);
                    break;
                }
            case 8:
                {
                    panouq7.SetActive(false);
                    panouq8.SetActive(true);
                    break;
                }
            case 9:
                {
                    panouq8.SetActive(false);
                    panouq9.SetActive(true);
                    break;
                }
            case 10:
                {
                    panouq9.SetActive(false);
                    panouq10.SetActive(true);
                    break;
                }
			case 11:
				{
					panouq10.SetActive(false);
					panouq11.SetActive(true);
					break;
				}

			case 12:
				{
					panouq11.SetActive(false);
					panouq12.SetActive(true);
					break;
				}
			case 13:
				{
					panouq12.SetActive(false);
					panouq13.SetActive(true);
					break;
				}
			case 14:
				{
					panouq13.SetActive(false);
					panouq14.SetActive(true);
					break;
				}
			case 15:
				{
					panouq14.SetActive(false);
					panouq15.SetActive(true);
					break;
				}
        }
        NextVotebutton.SetActive(false);
        hintbutton.SetActive(true);
    }
}
