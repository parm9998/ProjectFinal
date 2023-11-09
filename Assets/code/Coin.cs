using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Coin : MonoBehaviour
{
    AudioSource asource;
    public AudioSource source;
    static int Score = 0;
    public TMP_Text ScoreText;

    // private int coinCount = 0;
    // [SerializeField] private TMP_Text coinText;
    // public TMP_Text coinText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Coins"))
        {
            source.Play();
            //PlayerController.numberOfCoins++;
            Destroy(collision.gameObject);
            //ScoreText.text =  "  : "+Score.ToString();
            Score++;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        asource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text =  ": " + Score.ToString();
        //coinText.text = "Point : " + coinCount;
    }
}
