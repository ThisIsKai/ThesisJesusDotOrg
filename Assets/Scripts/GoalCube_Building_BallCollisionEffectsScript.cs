using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalCube_Building_BallCollisionEffectsScript : MonoBehaviour
{
    public bool buildingHasBeenHit;

    float buildingRemovalTimer;
    public float buildingRemovalDelay;

    private MeshRenderer myBuildingMeshRender;
    private Vector3 myBuildingScale;
    public bool myBuilingMeshRenderIsOn;
    public bool myFailingHologramMeshRendIsOn;

    //private float flashBeforeRemovalTimer;
    //public float flashingBuildingEffectLength;

    //  private bool scoreGoesUp;
    // bool waitAFrame;


    private void Start()
    {
        if (this.gameObject.GetComponent<MeshRenderer>() != null)
        {
            myBuildingMeshRender = this.gameObject.GetComponent<MeshRenderer>();
            buildingRemovalTimer = 0f;
        }
    }//end Start function


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            buildingHasBeenHit = true;
        }

    } //end OnTriggerEnter function


    private void FixedUpdate()
    {
        if (buildingHasBeenHit == true)
        {
            if (myBuildingMeshRender != null && myBuildingMeshRender.enabled) 
            {
                myBuildingMeshRender.enabled = false;
            }
                this.gameObject.GetComponent<Collider>().enabled = false;

            foreach (Transform child in transform)
            {
                MeshRenderer myChildrenMeshRend;
                myChildrenMeshRend = child.gameObject.GetComponent<MeshRenderer>();
                if (myChildrenMeshRend != null && myChildrenMeshRend.enabled) 
                {
                    myChildrenMeshRend.enabled = false;
                }
            }//end for each child in transform

        } //end if buildingHasBeenHit==true
    }//end FixedUpdate function

}//END GOALlCUBE_BUILDING_BALLCOLLISIONEFFECTS SCRIPT





