using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winner : MonoBehaviour
{
    public AudioSource audioSource;
    public ParticleSystem particleSystem;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider myCollider)
    {
        if (myCollider.gameObject.tag == ("Player"))
        {
            particleSystem.Play();
            audioSource.Play();
        }
    }
}

