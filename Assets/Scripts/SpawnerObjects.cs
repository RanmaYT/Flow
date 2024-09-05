using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UIElements;

public class SpawnerObjects : MonoBehaviour
{
    [SerializeField] private GameObject[] objectsPrefab;
    [SerializeField] private GameManager gameManager;

    private Vector3[] positions = new Vector3[3];
    private float timeUntilNextSpawn;
    private int obstaclesNumber;
    private int whiteCoinsRestart;

    public float spawnTime = 2f;

    private void Awake()
    {
        positions[0] = new Vector3(-3, 26, 0);
        positions[1] = new Vector3(0.5f, 26, 0);
        positions[2] = new Vector3(4, 26, 0);

        Spawn();
    }

    private void Update()
    {
        SpawnLoop();
    }

    private void SpawnLoop()
    {
        /// This function count the time to call spawn again and again after the spawnTime is reached;

        timeUntilNextSpawn += Time.deltaTime;

        if(timeUntilNextSpawn >= spawnTime && gameManager.isGameOver != true)
        {
            Spawn();
            obstaclesNumber = 0;
            whiteCoinsRestart--;
            timeUntilNextSpawn = 0;
        }
    }

    private void Spawn()
    {
        /// This function spawn a obstacle or a coin for each position, and make sure that is the max of 2 obstacles
        

        for(int i = 0; i < positions.Length; i++)
        {
            int index = Random.Range(0, objectsPrefab.Length + 1);

            if(whiteCoinsRestart > 0 && index == 1)
            {
                index = 0;
            }

            if(index == 1)
            {
                whiteCoinsRestart += 20;
            }

            if(index == 2)
            {
                obstaclesNumber++;
            }

            if(obstaclesNumber > 2)
            {
                index = 0;
            }

            if(index != 3)
            {
                Instantiate(objectsPrefab[index], positions[i], Quaternion.identity);
            }
        }
    }
}
