using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour

{
    //public AudioSource audioSource;

    void Start()
    {
        //audio = GetComponent<AudioSource>();

    }
    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if (playerInventory != null)
        {
            playerInventory.TableCollected();
            //audioSource.Play();
            gameObject.SetActive(false);
        }
    }
}
