using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameScript : MonoBehaviour
{
    public string sceneName = "SampleScene";
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.DeleteKey("highScore");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startGame() {
        Debug.Log("clicked");
        SceneManager.LoadScene(sceneName);
    }
}
