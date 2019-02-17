using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bladeAmmo : MonoBehaviour
{
	public GameObject mySword;
	public bool bladeIsActive;
    public GameObject lHand;
    public GameObject rHand;
    // Start is called before the first frame update
    void Start()
    {
        bladeIsActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        VRTK.VRTK_ControllerEvents l_hand = lHand.GetComponent<VRTK.VRTK_ControllerEvents>();
        VRTK.VRTK_ControllerEvents r_hand = rHand.GetComponent<VRTK.VRTK_ControllerEvents>();
        bool l_buttonTwo = l_hand.IsButtonPressed(VRTK.VRTK_ControllerEvents.ButtonAlias.TriggerPress);
        bool r_buttonTwo = r_hand.IsButtonPressed(VRTK.VRTK_ControllerEvents.ButtonAlias.TriggerPress);
        if (l_buttonTwo || r_buttonTwo)
        {
            Debug.Log("reactivated");
            mySword.SetActive(true);
            bladeIsActive = true;
        }// if button 
        if (Input.GetKey("a")){
        	mySword.SetActive(true);
        	bladeIsActive = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "L_Cube")
        {
            VRTK.VRTK_ControllerEvents l_hand = lHand.GetComponent<VRTK.VRTK_ControllerEvents>();
            
            bool l_buttonTwo = l_hand.IsButtonPressed(VRTK.VRTK_ControllerEvents.ButtonAlias.TriggerPress);
           
            if (l_buttonTwo )
            {
                Debug.Log("reactivated");
                mySword.SetActive(true);
                bladeIsActive = true;
            }// if button 
        }
        if (other.name == "R_Cube")
        {
            VRTK.VRTK_ControllerEvents r_hand = rHand.GetComponent<VRTK.VRTK_ControllerEvents>();

            bool l_buttonTwo = r_hand.IsButtonPressed(VRTK.VRTK_ControllerEvents.ButtonAlias.TriggerPress);

            if (l_buttonTwo)
            {
                Debug.Log("reactivated");
                mySword.SetActive(true);
                bladeIsActive = true;
            }// if button 
        }
    }
    public void turnOffSword(){
    	mySword.SetActive(false);
    	bladeIsActive = false;
    }
    public void turnOnSword()
    {
        mySword.SetActive(true);
        bladeIsActive = true;
    }
}
