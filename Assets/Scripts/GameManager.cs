using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GameManager : MonoBehaviour
{
    [SerializeField] SpawnerObjects spawner;
    [SerializeField] PlayerPointsCounter playerPoints;
    [SerializeField] GameObject backgroundGameOver;

    private int pointsRange;

    public int pointsCount;
    public bool isRising;
    public bool isGameOver;

    // Start is called before the first frame update
    void Start()
    {
        pointsRange = 15;
    }

    // Update is called once per frame
    void Update()
    {
        pointsCount = playerPoints.points;

        ChangeSpawnTime();

        if(isGameOver)
        {
            backgroundGameOver.SetActive(true);
        }
    }

    private void ChangeSpawnTime()
    {
        /// Here, everytime the player get a certain amount of points, the spawnTime gets reduced;

        if (pointsCount >= pointsRange)
        {
            pointsRange *= 2;

            isRising = true; 

            spawner.spawnTime *= 0.9f;

            if(spawner.spawnTime <= 1)
            {
                spawner.spawnTime = 1;
            }
        }
    }
}
