using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public int Score;
    public Text ScoreText;
    void Start()
    {
        Score = 0;
        ScoreText.text = Score.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateScore()
    {
        Score++;
        ScoreText.text = Score.ToString();
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
    public void AnaMenu()
    {
        SceneManager.LoadScene(1);
    }
}
