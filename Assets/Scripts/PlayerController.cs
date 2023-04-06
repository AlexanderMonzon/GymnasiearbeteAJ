using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerMovementSpeed = 15.0f;
    public float xBound = 50.0f;
    public float zBound = 50.0f;
    public int playerHealth = 3;
    public Rigidbody playerRb;
    public Vector3 Vector3playerSpawnPos;

    // Start is called before the first frame update
    void Start()
    {
        playerRb= GetComponent<Rigidbody>();
        Vector3playerSpawnPos= transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerHealth > 0)
        {
            PlayerMovement();
        }
        else
        {
            SceneManager.LoadScene(4);
        }
    }

    void PlayerMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * playerMovementSpeed * horizontalInput * Time.deltaTime);
        transform.Translate(Vector3.forward * playerMovementSpeed * verticalInput * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            playerMovementSpeed = 25.0f;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            playerMovementSpeed = 15.0f;
        }

        //Restrictions
        if (transform.position.x < -xBound)
        {
            transform.position = new Vector3(-xBound, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xBound)
        {
            transform.position = new Vector3(xBound, transform.position.y, transform.position.z);
        }
        if (transform.position.z < -zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zBound);
        }
        if (transform.position.z > zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zBound);
        }
    }
}
