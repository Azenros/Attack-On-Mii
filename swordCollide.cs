using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordCollide : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    public AudioClip hard_slash;

    private AudioSource source;

    private void OnTriggerEnter(Collider other)
    {
        source.PlayOneShot(hard_slash, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
