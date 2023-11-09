using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public  void ExitGame()
    {
        Application.Quit();
    }
    public void RestartScene()
    {
        // int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        // SceneManager.LoadScene(currentSceneIndex);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
