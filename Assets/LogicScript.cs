using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText; //make reference to text
    public GameObject gameOverScreen;
    public bool isGameOver = false;
    public AudioSource passSFX;
    public int highScore;
    public Text highScoreText;

    // Start is called before the first frame update
    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd) {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
        passSFX.Play();
    }
    
    public void gameOver() {
        gameOverScreen.SetActive(true);
        isGameOver = true;
    }

    public void restartGame() {
        Debug.Log("restartGame entered");
        Debug.Log(PlayerPrefs.GetInt("highScore", 0));
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    
    void Start()
    {
        passSFX = GetComponent<AudioSource>();  
        initHighScore();      
    }

    // Update is called once per frame
    void Update()
    {
        updateHighScore();
    }

    public void initHighScore() {
        highScoreText.text = PlayerPrefs.GetInt("highScore", 0).ToString();
        highScore = PlayerPrefs.GetInt("highScore", 0);
        highScoreText.text = "High Score: " + highScoreText.text;
    }

    public void updateHighScore() {
        if (playerScore > highScore) {
            highScore = playerScore;
            PlayerPrefs.SetInt("highScore", playerScore);
            highScoreText.text = "High Score: " + highScore.ToString();
        }
    }

    public void Reset() {
        PlayerPrefs.DeleteKey("highScore");
    }
}
