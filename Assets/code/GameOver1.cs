using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver1 : MonoBehaviour
{
    public string sceneToLoad = "GameOver";
  
    private void OnTriggerEnter2D (Collider2D other)
    {
        
            SceneManager.LoadScene(sceneToLoad);

    }

}
