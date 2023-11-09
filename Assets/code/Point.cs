using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;
using TMPro;

public class Point : MonoBehaviour
{
    static int Score = 0;
    public TMP_Text ScoreText;

    //Point.AddScore();

    void Start()
    {
        
    }

    
    void Update()
    {
        ScoreText.text = "SCORE : " + Score;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Point")
        {
            AddScore();
        }
        //Destroy(other.gameObject);
        AddScore();

        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
    }

    void AddScore()
    {
        Score++;
        //ScoreText.text = "SCORE : " + Score.ToString();
        //ScoreText.text = Score.ToString();
    }

    /*private void Start()
    {
        Score = PlayerPrefs.GetInt("Score", 0);
    }*/

    /*public static void AddScore(int point)
    {
        Score += point;
        PlayerPrefs.SetInt("Score", Score);
    }*/

}
