using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepSound : MonoBehaviour

{
    public AudioClip footstepSound; // Reference to the footstep sound

    private AudioSource audioSource; // Reference to the AudioSource component

    private bool isMoving = false; // Flag to track if the player is moving

    private void Start()
    {
        // Get the AudioSource component attached to the player GameObject
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        // Check if the player is moving
        if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
        {
            if (!isMoving)
            {
                // Player started moving, so play footstep sound
                isMoving = true;
                audioSource.clip = footstepSound;
                audioSource.loop = true; // Allow the footstep sound to loop
                audioSource.Play();
            }
        }
        else
        {
            if (isMoving)
            {
                // Player stopped moving, so stop footstep sound
                isMoving = false;
                audioSource.Stop();
            }
        }
    }
}
