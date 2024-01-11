using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusSpawnScript : MonoBehaviour
{
    public GameObject cactus;
    public float spawnRate = 2;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
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
    }

    void spawnCactus()
    {
        Instantiate(cactus, transform.position, transform.rotation);
    }
}
