using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightHand : MonoBehaviour
{
    public GameObject mySword;
    public AudioClip unsheathe_sound;
    private AudioSource source;
    public bool bladeIsActive;
   
    public GameObject rHand;

    private float lowVol = 0.25f;
    private float highVol = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        bladeIsActive = true;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void Awake()
    {
        source = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (bladeIsActive)
        {
            return;
        }

        VRTK.VRTK_ControllerEvents r_hand = rHand.GetComponent<VRTK.VRTK_ControllerEvents>();

            
        Debug.Log("reactivated");
        source.PlayOneShot(unsheathe_sound, 0.5f);
        mySword.SetActive(true);
        bladeIsActive = true;
            // if button 
        
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
    public bool readBlade()
    {
        return bladeIsActive;
    }
}
