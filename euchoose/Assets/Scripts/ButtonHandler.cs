using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour {

    public Text happinesst, economyt, cohesiont;
    public GameObject statsPanel, gameover_economy, gameover_happiness, gameover_cohesion, NextVotebutton;
    public void Activare_Panou()
    {
        happinesst.text = "Acceptability level: " + SceneHandler.happiness.ToString() + "%";
        cohesiont.text = "Countries' cohesion: " + SceneHandler.cohesion.ToString() + "%";
        economyt.text = "Europe's economy: " + SceneHandler.economy.ToString() + "%";
        statsPanel.SetActive(true);
        gameover_happiness.SetActive(false);
        gameover_economy.SetActive(false);
        gameover_cohesion.SetActive(false);
        NextVotebutton.SetActive(false);
    }

}
