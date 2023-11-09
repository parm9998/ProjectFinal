using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Maneger : MonoBehaviour
{
    [SerializeField] private GameObject Box;
    [SerializeField] private float maxX,maxX1;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private float spawnRate;

    private bool isGameStarted = false;
// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump") && !isGameStarted)
        {
            StartSpawning();
            isGameStarted = true;
        }
    }

    private void StartSpawning()
    {
        InvokeRepeating("SpawnBox",0.5f,spawnRate);
    }

    private void SpawnBox()
    {
        Vector2 spawnPos = spawnPoint.position;
        spawnPos.x = Random.Range(maxX, maxX1);
        Instantiate(Box,spawnPos,Quaternion.identity);
    }


    
}
