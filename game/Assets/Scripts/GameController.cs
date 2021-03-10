using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{ 
    public int scoreTotal;
    public Text scoreText;
    public GameObject gameOverPainel;

    public static GameController instance;


    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    public void UpdateScoreText()
    {
        scoreText.text = scoreTotal.ToString().PadLeft(7, '0');
    }

    public void ShowGameOver()
    {
        gameOverPainel.SetActive(true);
    }

    public void RestartGame(string name)
    {
        SceneManager.LoadScene(name);
    }
}
