using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {
   public Text text;
   private enum States {cell_0, cell_01, doors_0, doors_1,
                        basin_0, basin_1, bazgroly_1, corridor_0, mirror_0, lock_0, piss_0};
   States myState;
     void state_cell()
    {
        text.text = "Jesteś w celi i chcesz uciec. Na łóżku dostrzegasz poniszczone \n" +
                        "kartki papieru oraz lustro na ścianie \n" +
                        "Nacisnij L aby podejsc do lustra  \n" +
                        "Nacisnij Z aby podejsc do zamku w drzwiach";
        if (Input.GetKeyDown(KeyCode.L))
        {
            myState = States.mirror_0;
        }
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            myState = States.lock_0;
        }
    }  

    void Start () {
        myState = States.cell_0; 
    }
	
	void Update () {
        if (myState == States.cell_0){state_cell();}
        else if (myState == States.mirror_0){ state_mirror_0(); }
        else if (myState == States.lock_0) { state_lock_0(); }
        {

        }
       
    }

    private void state_lock_0()
    {
        text.text = "Zamek jest przerdzewiały\n" +
                      "Nacikaj na niego. \n" +
                       "Nacisnij S aby nasikac \n";
        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.piss_0;
        }
    }

    private void state_mirror_0()
    {
        text.text = "Jestes przy lustrze. Jestes piekny. Twoj obraz w lustrze to przeszlosc \n" +
                      "kartki papieru oraz lustro na ścianie \n" +
                       "Nacisnij P aby powrocic na srodek celi \n";
        if (Input.GetKeyDown(KeyCode.P))
        {
            myState = States.cell_0;
        }
    }
}
