using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loop : MonoBehaviour
{
    public GameObject lHand;
    public GameObject rHand;
    // Start is called before the first frame update
    void Start() {

       
    }

    // Update is called once per frame
    void Update()
    {
        VRTK.VRTK_ControllerEvents l_hand = lHand.GetComponent<VRTK.VRTK_ControllerEvents>();
        VRTK.VRTK_ControllerEvents r_hand = rHand.GetComponent<VRTK.VRTK_ControllerEvents>();

        bool l_buttonOne = l_hand.IsButtonPressed(VRTK.VRTK_ControllerEvents.ButtonAlias.ButtonOnePress);
        bool r_buttonOne = r_hand.IsButtonPressed(VRTK.VRTK_ControllerEvents.ButtonAlias.ButtonOnePress);

       if (l_buttonOne || r_buttonOne)
        {
            Debug.Log("pressed");
            SceneManager.LoadScene("Rail Scene", LoadSceneMode.Additive);
        }

    }
}
