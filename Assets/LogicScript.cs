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
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    
    void Start()
    {
        passSFX = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
