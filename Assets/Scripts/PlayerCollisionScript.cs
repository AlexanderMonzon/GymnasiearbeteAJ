using UnityEngine;
using System;

public class PlayerCollisionScript : MonoBehaviour
{
    public GameObject collisionVFX;
    public AudioClip collisionSound;
    private AudioSource playerAudio;
    public Rigidbody playerRb;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAudio = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision other)
    {
        PlayerController playerController = GetComponent<PlayerController>();

        if (other.gameObject.CompareTag("Enemy"))
        {
            Instantiate(collisionVFX, transform.position, transform.rotation);
            playerAudio.PlayOneShot(collisionSound, 0.5f);

            other.gameObject.GetComponent<MeshRenderer>().enabled = false;
            other.gameObject.GetComponent<Collider>().enabled = true;

            Destroy(other.gameObject);

            playerController.playerHealth -= 1;
        }

        if (other.gameObject.CompareTag("Food"))
        {
            Instantiate(collisionVFX, transform.position, transform.rotation);
            playerAudio.PlayOneShot(collisionSound, 0.5f);

            other.gameObject.GetComponent<MeshRenderer>().enabled = false;
            other.gameObject.GetComponent<Collider>().enabled = true;

            Destroy(other.gameObject);

            transform.localScale += new Vector3(5, 5, 5);
        }
    }
}
