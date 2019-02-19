using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titan_killable : MonoBehaviour
{
    public GameObject blade;
    public GameObject rblade;
    public GameObject titan;
    public GameObject player;
    public GameObject gameOverScreen;
    public GameObject world;

    public AudioClip hard_slash;
    private AudioSource source;

    private void Awake()
    {
        source = player.GetComponent<AudioSource>();
        //hard_slash = player.GetComponent<AudioSource>().GetComponent<AudioClip>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("collide");
        if (blade.GetComponent<leftHand>().readBlade() && rblade.GetComponent<rightHand>().readBlade())
        { //register a kill, make titan disappear, make blade disappear
            
            Debug.Log("Kill get");
            blade.GetComponent<leftHand>().turnOffSword();
            rblade.GetComponent<rightHand>().turnOffSword();
            titan.SetActive(false);
            source.Play();

        }
        else
        { //teleport to game over screen and end play
            Debug.Log("END");
            gameOverScreen.SetActive(true);
            player.GetComponent<gameStat>().inPlay = false;
            player.transform.position = new Vector3(-125.8207f, -13.66788f, -4.377975f);
            //source.PlayOneShot(soft_slash, 1f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("t"))
        {
            player.GetComponent<gameStat>().inPlay = false;
            player.transform.position = new Vector3(-125.8207f, -13.66788f, -4.377975f);
        }
    }
}
