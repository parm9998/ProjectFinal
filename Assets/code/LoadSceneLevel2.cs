using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneLevel2 : MonoBehaviour
{
    public int next;

    void Start(){
        next = SceneManager.GetActiveScene().buildIndex + 1;
    }
    private void OnTriggerEnter2D (Collider2D other)
    {
        if(other.tag == "Player"){
            SceneManager.LoadScene(next);
        }
    }
    

}
