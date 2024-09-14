using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;
using System.Runtime.CompilerServices;

public class LogicScript : MonoBehaviour
{

    public GameObject gameOverScreen;

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        ScoreManagerScript.scoreCount = 0;
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void home()
    {
        SceneManager.LoadSceneAsync(0);
        ScoreManagerScript.scoreCount = 0;
    }


}
