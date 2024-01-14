using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public bool dinoIsAlive = true;
    public float jumpHeight;
    public LogicScript logic;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && dinoIsAlive)
        {
            myRigidBody.velocity = Vector2.up * jumpHeight;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "cactus")
        {
            // game over screen
            dinoIsAlive = false;
            logic.gameOver();
            Debug.Log("game over");
        }
    }
}
