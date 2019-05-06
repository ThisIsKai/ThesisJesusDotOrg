using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialArrowLightUpScript : MonoBehaviour 
{
    public KeyCode thisArrowActiveKey;
    public GameObject thisArrow;
    Renderer mySpriteRender;
    Vector3 resizeVector;

    // Start is called before the first frame update
    void Start()
    {
        mySpriteRender = this.gameObject.GetComponent<SpriteRenderer>();
        mySpriteRender.enabled = false;
         
    }
    // Update is called once per frame
    void Update()

    {
        if (Input.GetKey(thisArrowActiveKey))
        {
            mySpriteRender.enabled = true;

        } else { mySpriteRender.enabled = false; }

    }
}
