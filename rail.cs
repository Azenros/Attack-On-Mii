using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rail : MonoBehaviour
{
    public GameObject lHand;
    public GameObject rHand;
    public float velocity;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
        
    {
        VRTK.VRTK_ControllerEvents l_hand = lHand.GetComponent<VRTK.VRTK_ControllerEvents>();
        VRTK.VRTK_ControllerEvents r_hand = rHand.GetComponent<VRTK.VRTK_ControllerEvents>();
        bool triggerA = l_hand.IsButtonPressed(VRTK.VRTK_ControllerEvents.ButtonAlias.TriggerPress);
        bool triggerB = r_hand.IsButtonPressed(VRTK.VRTK_ControllerEvents.ButtonAlias.TriggerPress);
        if (triggerA && triggerB)
        {
            velocity += (-2 * Time.deltaTime);
        }
        if (player.GetComponent<gameStat>().inPlay){
           
            transform.Translate(Vector3.forward * velocity * Time.deltaTime);
        }
    }
}
