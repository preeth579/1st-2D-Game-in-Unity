using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManagerScript : MonoBehaviour
{

    public Text scoreText;
    public Text highscoretext;
    public static int scoreCount;
    public static int highscoreCount;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("HighScore"))
        {
            highscoreCount = PlayerPrefs.GetInt("HighScore");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (scoreCount > highscoreCount)
        {
            highscoreCount = scoreCount;
            PlayerPrefs.SetInt("HighScore" , highscoreCount );
        }
        scoreText.text = "SCORE : " + Mathf.Round(scoreCount);
        highscoretext.text = "HIGH SCORE : " + highscoreCount;
    }
}
