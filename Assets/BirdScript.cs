using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    //create reference for rigidbody2d
    public Rigidbody2D myRigidBody;
    public float flapStrength = 16;
    public LogicScript logic;
    public bool birdIsAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "angry bird";
        logic = GameObject.FindGameObjectWithTag("Logic tag").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive) {
            myRigidBody.velocity = Vector2.up * flapStrength;
        }
        if (transform.position.y < -14.63 || transform.position.y > 14.63) {
            gameEnds();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        gameEnds();
    }

    private void gameEnds() {
        logic.gameOver();
        birdIsAlive = false;
    }
}
