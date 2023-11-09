using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static int score;
    Text text;
    public static ScoreManager instance;
    // public Text text;
    // int score;
    void Start () {
        score = 0;
        text = GetComponent<Text>();

        if(instance == null)
        {
            instance = this;
        }
    }

    void Update()
    {
        text.text = "SCORE : " + score;
        // text.text = "X " + score;

    }
    public void ChangeScore(int coinValue)
    {
        score += coinValue;
        text.text = "SCORE : " + score;
    }

    
}
