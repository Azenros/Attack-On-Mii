using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public GameObject player;
    public AudioClip win_sound;
    private AudioSource source;
    // Start is called before the first frame update
    private void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        player.GetComponent<gameStat>().inPlay = false;
        player.transform.position = new Vector3(-125.8207f, -13.66788f, -4.377975f);
        source.PlayOneShot(win_sound, 0.75f);
    }
}
