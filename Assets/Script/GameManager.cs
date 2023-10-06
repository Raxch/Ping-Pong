using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Ball")]
    public GameObject ball;

    [Header("Player 1")]
    public GameObject player1Script;
    public GameObject player1Goal;

    [Header("Player 2")]
    public GameObject player2Script;
    public GameObject player2Goal;

    [Header("Score")]
    public GameObject player1Text;
    public GameObject player2Text;

    private int player1Score;
    private int player2Score;

    public void player1Scored()
    {
        player1Score++;
        player1Text.GetComponent<TextMeshProUGUI>().text = player1Score.ToString();
        ResetPositon();
    }
    public void player2Scored()
    {
        player2Score++;
        player2Text.GetComponent<TextMeshProUGUI>().text = player2Score.ToString();
        ResetPositon();
    }
    public void ResetPositon()
    {
        ball.GetComponent<Ball>().Reset();
        player1Script.GetComponent<Player>().Reset();
        player2Script.GetComponent<Player>().Reset();
    }

    public void exit()
    {
        Application.Quit();
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            exit();
        }
    }
}
