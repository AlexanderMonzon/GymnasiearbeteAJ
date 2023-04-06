using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManagerScript : MonoBehaviour
{
    public GameObject[] enemyPrefabsList;
    public GameObject[] spawnPrefabsList;
    ScoreScript ScoreScript;
    MoveEnemy MoveEnemyScript;

    public float spawnRangeX = 50.0f;
    public float spawnRangeZ = 50.0f;
    public float startDelay = 0f;
    public float spawnInterval;
    int enemyModel;

    public string enemyType;
    public string[] enemyTypeList = { "U2D", "D2U", "L2R", "R2L" };

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", startDelay, spawnInterval);
    }

    public void SpawnRandomEnemy()
    {
        enemyType = enemyTypeList[Random.Range(0, enemyTypeList.Length)];
        enemyModel = Random.Range(0, enemyPrefabsList.Length);

        if (enemyType == "U2D")
        {
            Vector3 spawnPosHorizontalU2D = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 2, spawnRangeZ * 2);
            Instantiate(enemyPrefabsList[enemyModel], spawnPosHorizontalU2D, enemyPrefabsList[enemyModel].transform.rotation);
        }
        else if (enemyType == "D2U")
        {
            Vector3 spawnPosHorizontalD2U = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 2, -spawnRangeZ * 2);
            Instantiate(enemyPrefabsList[enemyModel], spawnPosHorizontalD2U, enemyPrefabsList[enemyModel].transform.rotation);
        }
        else if (enemyType == "L2R")
        {
            Vector3 spawnPosVertical1 = new Vector3(2 * spawnRangeX, 1.5f, Random.Range(-spawnRangeZ, spawnRangeZ));
            Instantiate(enemyPrefabsList[enemyModel], spawnPosVertical1, enemyPrefabsList[enemyModel].transform.rotation);
        }
        else if (enemyType == "R2L")
        {
            Vector3 spawnPosVertical1 = new Vector3(-spawnRangeX * 2, 1.5f, Random.Range(-spawnRangeZ, spawnRangeZ));
            Instantiate(enemyPrefabsList[enemyModel], spawnPosVertical1, enemyPrefabsList[enemyModel].transform.rotation);
        }
    }
}
