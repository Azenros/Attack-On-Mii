using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dodge : MonoBehaviour
{
    public GameObject lHand;
    public GameObject rHand;
    public float dodge_factor = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        VRTK.VRTK_ControllerEvents l_hand = lHand.GetComponent<VRTK.VRTK_ControllerEvents>();
        VRTK.VRTK_ControllerEvents r_hand = rHand.GetComponent<VRTK.VRTK_ControllerEvents>();

        bool l_buttonTwo = l_hand.IsButtonPressed(VRTK.VRTK_ControllerEvents.ButtonAlias.ButtonTwoPress);
        bool r_buttonTwo = r_hand.IsButtonPressed(VRTK.VRTK_ControllerEvents.ButtonAlias.ButtonTwoPress);

        if (l_buttonTwo)
        {
            
            if (transform.position.x >= -2.5)
            {
                transform.position -= new Vector3(dodge_factor, 0, 0);
            }
        }
        if (r_buttonTwo)
        {
            if (transform.position.x <= 2.5)
            {
                
                transform.position += new Vector3(dodge_factor, 0, 0);
            }
        }
    }
}
