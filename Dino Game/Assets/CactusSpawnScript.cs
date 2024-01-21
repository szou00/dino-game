using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusSpawnScript : MonoBehaviour
{
    public GameObject cactus;
    private float spawnRate = 4;
    private float timer = 0;
    public LogicScript logic;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        spawnCactus();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnCactus();
            timer = 0;
        }

        // Changing difficulty of the game

        if (logic.score < 50) {}
        else if (logic.score >= 50 && logic.score < 100)
        {
            spawnRate = 3;
        }
        else if (logic.score >= 100 && logic.score < 250)
        {
            spawnRate = 2;
        }
        else
        {
            spawnRate = 1;
        }
    }

    void spawnCactus()
    {
        Instantiate(cactus, transform.position, transform.rotation);
    }
}
