using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMIddleScript : MonoBehaviour
{
    //reference
    public LogicScript logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic tag").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision) {
        Debug.Log("enter1");
        if (collision.gameObject.layer == 3 && !logic.isGameOver) {
            Debug.Log("enter2");
            logic.addScore(1);
            Debug.Log(logic.playerScore);
        }
        
    }
}
