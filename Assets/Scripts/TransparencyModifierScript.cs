using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransparencyModifierScript : MonoBehaviour
{
   public float alphaRandom_min;
   public float alphaRandom_max;
   public float alphaBase_value;


    //public float fadeSpeed;
   

    void Start()
    {
        
    }


    void Update()
    {
        this.GetComponent<MeshRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, alphaBase_value);
        Color color = this.GetComponent<MeshRenderer>().material.color;
        color.a = alphaBase_value + Random.Range(alphaRandom_min, alphaRandom_max);
        //color.a -= Time.deltaTime * fadeSpeed;
        this.GetComponent<MeshRenderer>().material.color = color;
    }
}
