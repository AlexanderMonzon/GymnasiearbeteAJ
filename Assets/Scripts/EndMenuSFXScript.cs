using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EndMenuSFXScript : MonoBehaviour
{
    public AudioClip introSFX;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(introSFX, 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
