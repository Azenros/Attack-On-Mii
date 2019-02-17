using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftHand : MonoBehaviour
{
    public GameObject mySword;
    public AudioClip unsheathe_sound;
    private AudioSource source;
    public bool bladeIsActive;
    public GameObject lHand;

    private float lowVol = 0.25f;
    private float highVol = 1f;

    void Start()
    {
        bladeIsActive = true;
    }

    private void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        VRTK.VRTK_ControllerEvents l_hand = lHand.GetComponent<VRTK.VRTK_ControllerEvents>();
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (bladeIsActive)
        {
            return;
        }
        Debug.Log("reactivated");
        source.PlayOneShot(unsheathe_sound, 0.5f);
        mySword.SetActive(true);
        bladeIsActive = true;
            // if button 
        
       
    }
    public bool readBlade()
    {
        return bladeIsActive;
    }
    public void turnOffSword()
    {
        mySword.SetActive(false);
        bladeIsActive = false;
    }
    public void turnOnSword()
    {
        mySword.SetActive(true);
        bladeIsActive = true;
    }
}
