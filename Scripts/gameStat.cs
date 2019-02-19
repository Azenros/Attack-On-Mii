using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameStat : MonoBehaviour
{
	public List <GameObject> titans;
	public GameObject stage;
	public GameObject player;
    public GameObject lHand;
    public GameObject rHand;
   
    private GameObject gameOverSign;
	public bool inPlay = true;
    // Start is called before the first frame update
    void Start()
    {
        gameOverSign.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        VRTK.VRTK_ControllerEvents l_hand = lHand.GetComponent<VRTK.VRTK_ControllerEvents>();
        if (!inPlay){
            bool l_buttonOne = l_hand.IsButtonPressed(VRTK.VRTK_ControllerEvents.ButtonAlias.ButtonOnePress);
            if (l_buttonOne){
        		stage.transform.position = new Vector3(0.44f , 0, -28.743f);
        		player.transform.position = new Vector3(0.44f,0,-22.5f);
        		for(int i = 0; i < titans.Count; i++){
        			titans[i].SetActive(true);
        		}
                stage.GetComponent<rail>().velocity = -10;
                inPlay = true;
               
               
            }
        }
    }

}
