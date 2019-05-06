using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayObjectRemovalAfterStartScript : MonoBehaviour // { ATTACHED TO ANY OBJECT THAT YOU WANT TO APPLY IT TO}
{                                                               // DESTROYS THE OBJECT AFTER A SET NUMBER OF FRAMES 
                                                                // AFTER THE START OF THE GAME   

    public float framesBeforeRemoval;
    float removalTimer;


    void Start()
    {
        removalTimer = 0f;
    } //end Start function


    void Update()
    {
        if (removalTimer<= framesBeforeRemoval)
        {
            removalTimer = removalTimer + 1;
        }
        else
        { 
        Destroy(this.gameObject); 
        }
    } //end update function


}//END DELAY OBJECT REMOVAL AFTER START SCRIPT
