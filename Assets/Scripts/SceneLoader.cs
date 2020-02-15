using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    //cached reference
    GameStatus gameStatus;

    public void Start()
    {
        gameStatus = FindObjectOfType<GameStatus>();
    }
    public void LoadFirstScene()
    {
        SceneManager.LoadScene(1);
        gameStatus.ResetGame();
    }


    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
        
    }



    public void QuiteGame()
    {
        Application.Quit();
    }
}
