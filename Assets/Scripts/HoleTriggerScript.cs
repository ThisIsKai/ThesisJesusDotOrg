using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleTriggerScript : MonoBehaviour //{ATTACHED TO THE HOLE_TRIGGER OBJECT}
{                                              // 
    private Rigidbody myRB;
    private GameObject myGameObject;
    private Collider myCollider;
    public bool gameIsOver;

    void Start()
    {
        gameIsOver = false;
        myRB = this.gameObject.GetComponent<Rigidbody>();
        myGameObject = this.gameObject;
        myCollider = this.gameObject.GetComponent<Collider>();

    }// end Start function


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            DestroyBall();
            GameOver();
        }
    }//end OnTriggerEnter function


    void DestroyBall()
    {

    } //end DestroyBall function

    void GameOver()
    {
        gameIsOver = true;

    }//end GameOver function


} //END HOLE TRIGGER SCRIPT
