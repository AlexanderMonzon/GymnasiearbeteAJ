using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    public string enemyMoveType;
    public float enemySpeed;

    // Start is called before the first frame update
    void Start()
    {
        EnemySpawnManagerScript spawnManager = GameObject.Find("EnemySpawnManager").GetComponent<EnemySpawnManagerScript>();
        string enemyType = spawnManager.enemyType;
        enemyMoveType = enemyType;
    }

    // Update is called once per frame
    void Update()
    {
        EnemyMovement();
        DestroyOutOfBounds();
    }

    //Enemy movement code depending on their type
    void EnemyMovement()
    {
        if (enemyMoveType == "D2U")
        {
            transform.Translate(Vector3.forward * Time.deltaTime * enemySpeed);
        }
        else if (enemyMoveType == "U2D")
        {
            transform.Translate(Vector3.forward * Time.deltaTime * -enemySpeed);
        }
        else if (enemyMoveType == "L2R")
        {
            transform.Translate(Vector3.left * Time.deltaTime * enemySpeed);
        }
        else if (enemyMoveType == "R2L")
        {
            transform.Translate(Vector3.left * Time.deltaTime * -enemySpeed);
        }
    }

    void DestroyOutOfBounds()
    {
        if (gameObject.transform.position.x > 100)
        {
            Destroy(gameObject);
        }
        else if (gameObject.transform.position.x < -100)
        {
            Destroy(gameObject);
        }
        else if (gameObject.transform.position.z > 100)
        {
            Destroy(gameObject);
        }
        else if (gameObject.transform.position.z < -100)
        {
            Destroy(gameObject);
        }
    }
}
