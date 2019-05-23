using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualEffectsScript : MonoBehaviour // {ATTACHED TO AN OBJECT THAT YOU WANT TO ADD THESE EFFECTS TO}
{

    public GameObject sourceObject;
    private Collider hologramCollider;
    private MeshRenderer myBuildingMeshRend;
    private MeshRenderer myHologramMeshRend;
    private GameObject myHologramObj;

    float coinFlip;
    public float coinFlipChance;
    public float modifiedCoinFlip;
    private bool collider_On;
   
     private bool myBuildingMeshRend_On;


    //*****POSITION RANDOMIZER STUFF*****
    public bool jitter_Position;
    public float jitterPosRandomizer_min;
    public float jitterPosRandomizer_max;
    private float randomizerX;
    private float randomizerY;
    //*******************************

  //*****FRAME DELAY STUFF*****
    public float frameDelayRandomizer_Min;
    public float frameDelayRandomizer_Max;
    public float frameDelay_BaseValue;
    private float frameDelay_RandomizedValue;
    private float frameDelayTimer;
    //*******************************


    //*****SCALE RANDOMIZER STUFF*****
    public bool jitter_Scale;
    public float scaleRangeMod_min;
    public float scaleRangeMod_max;
    private float scaleRandX;
    private float scaleRandY;
    private float scaleRandZ;
    //*******************************

    //===================================================================

    void Start()
    {
        myBuildingMeshRend = sourceObject.GetComponent<MeshRenderer>();
        hologramCollider = this.gameObject.GetComponent<Collider>();
        myHologramMeshRend = this.gameObject.GetComponent<MeshRenderer>();
        myHologramObj = this.gameObject;
        collider_On = true;
        myBuildingMeshRend_On = true;
        myHologramMeshRend.enabled = false;
        modifiedCoinFlip = coinFlip;

        //setRandomizedFrameValue = false;
       // waitSomeMoreFrames = false;

    } //END START FUNCTION

    //===================================================================

    void FixedUpdate()
    {   
            if (myBuildingMeshRend_On == true)
            {
                if (jitter_Scale == true) { JitterScale(); }
                if (jitter_Position == true) { JitterPosition(); }
            }


            if (collider_On == false)
            {
                TurnOffMyCollider();
            }


            coinFlip = Random.Range(0f, 2.0f);

            if ((coinFlip >= coinFlipChance) || (modifiedCoinFlip >= coinFlipChance))
        {
                 if (myBuildingMeshRend != null)
                 {
                    modifiedCoinFlip = modifiedCoinFlip + Random.Range(0.0f, .005f);
                    TurnOffMyBuildingMeshRender();
                    myBuildingMeshRend_On = false;
                    TurnOnMyHologramRender();
                  }
  

        }
            else
            {

                if (myBuildingMeshRend != null)
                {
                   TurnOnMyBuildingMeshRender();
                myBuildingMeshRend_On = true;
                TurnOffMyHologramMeshRender();
            }
            }

            if (myBuildingMeshRend_On == true)
            {
                myHologramMeshRend.enabled = false;
            }
      //  }
    }//END UPDATE FUNCTION

    //===================================================================
    void TurnOffMyBuildingMeshRender()
    {
        myBuildingMeshRend.enabled = false;
    }

    void TurnOnMyBuildingMeshRender()
    {
        if (myBuildingMeshRend != null) { myBuildingMeshRend.enabled = true; }       
    }

    void TurnOffMyHologramMeshRender()
    {
        myHologramMeshRend.enabled = false;
    }

    void TurnOnMyHologramRender()
    {
        myHologramMeshRend.enabled = true;
    }

    void TurnOffMyCollider()
    {
        hologramCollider.enabled = false;
    }


    //=================================================================== 

    void JitterScale()
    {
        scaleRandX = Random.Range(jitterPosRandomizer_min, jitterPosRandomizer_max);
        scaleRandY = Random.Range(jitterPosRandomizer_min, jitterPosRandomizer_max);
        scaleRandZ = Random.Range(jitterPosRandomizer_min, jitterPosRandomizer_max);
        Vector3 jitterObjectScale = this.gameObject.transform.localScale;
        jitterObjectScale = new Vector3(scaleRandX, scaleRandY, scaleRandZ);
        this.gameObject.transform.localScale = jitterObjectScale;

    }//END JITTER SCALE FUNCTION
 
//===================================================================

    void JitterPosition()
    {
        randomizerX = Random.Range(scaleRangeMod_min, scaleRangeMod_max);
        randomizerY = Random.Range(scaleRangeMod_min, scaleRangeMod_max);
        var sourceObjectPos = sourceObject.transform.position;
        var jitterObjectPos = this.gameObject.transform.position;
        jitterObjectPos.x = sourceObjectPos.x + randomizerX;
        jitterObjectPos.y = sourceObjectPos.y + randomizerY;
        this.gameObject.transform.position = jitterObjectPos;

    } // END JITTER POSITION FUNCTION

//===================================================================

} //END VISUAL EFFECTS SCRIPT

