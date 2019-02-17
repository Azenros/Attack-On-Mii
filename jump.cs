using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    public GameObject lHand;
    public GameObject rHand;
    public float movingUp = 0;
    public float enable = 0;
    public float upSpeed = 0f;
    public float cooldown = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if (movingUp > 3)
        {
            movingUp = 1;
        }
        
        VRTK.VRTK_ControllerEvents l_hand = lHand.GetComponent<VRTK.VRTK_ControllerEvents>();
        VRTK.VRTK_ControllerEvents r_hand = rHand.GetComponent<VRTK.VRTK_ControllerEvents>();

        bool l_buttonOne = l_hand.IsButtonPressed(VRTK.VRTK_ControllerEvents.ButtonAlias.ButtonOnePress);
        bool r_buttonOne = r_hand.IsButtonPressed(VRTK.VRTK_ControllerEvents.ButtonAlias.ButtonOnePress);
        
        if ((Input.GetKey("a") || l_buttonOne || r_buttonOne)  && (enable < 0.1)){
            
        	movingUp += 2.1f;
        	enable = 2;
        }
        
        enable -= Time.deltaTime;
        movingUp -= Time.deltaTime;
        if (movingUp > 0.0){
            if (transform.position.y < 6)
            {
                transform.position += Vector3.up * upSpeed * Time.deltaTime;
            }
            else
            {
                movingUp = 0;
            }
        }
        else{
            if (transform.position.y > -5.5f)
            {
                movingUp = 0;
                transform.position -= Vector3.up *  Time.deltaTime;
            }
        }
    }
}
 