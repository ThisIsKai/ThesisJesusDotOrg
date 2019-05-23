using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialArrowLightUpScript : MonoBehaviour 
{
    public KeyCode thisArrowActiveKey;
    public GameObject thisArrow;
    Renderer mySpriteRender;
    Vector3 resizeVector;
    float timer;
    TuningControlScript tuner;
    Color defaultColor;
    Color destColor;

    // Start is called before the first frame update
    void Start()
    {
        mySpriteRender = this.gameObject.GetComponent<SpriteRenderer>();
        mySpriteRender.enabled = false;
        tuner = (TuningControlScript)Resources.Load("TuningData");
        defaultColor = mySpriteRender.material.GetColor("_EmissionColor");
        destColor = Color.black;
    }
    // Update is called once per frame
    void Update()

    {
        if (Input.GetKey(thisArrowActiveKey))
        {
            mySpriteRender.enabled = true;
            timer += Time.deltaTime;
            float percent = (timer* 60f)/ tuner.max_KeyPressLength;
            mySpriteRender.material.SetColor("_EmissionColor", Color.Lerp(defaultColor, destColor, percent));

        } else { 
            mySpriteRender.enabled = false;
            timer = 0;
        }


    }
}
