using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalCube_Main_ColliderDisablerScript : MonoBehaviour
{
    bool hasMyBuildingBeenHit;
    GoalCube_Building_BallCollisionEffectsScript myBuilding;

    void Start()
    {
        myBuilding = transform.GetChild(0).GetComponent<GoalCube_Building_BallCollisionEffectsScript>();
    }
    private void FixedUpdate()
    {
        if (myBuilding != null){
            hasMyBuildingBeenHit = myBuilding.buildingHasBeenHit;
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (hasMyBuildingBeenHit == true)
        {

        }
    }

}
