using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarMovementScript : MonoBehaviour 
{
    public Transform leftSlider; // the transform of the left slider object
    public Transform rightSlider; // the transform of the right slider object
    private Vector3 eulerAngles; // the angle that the bar will be at, in Euler angles

    void FixedUpdate()
    {
        transform.position = ((leftSlider.position + rightSlider.position) / 2);
       
         eulerAngles.z = Mathf.Atan2(rightSlider.position.y - leftSlider.position.y,
                                    rightSlider.position.x - leftSlider.position.x)*
                                    Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(eulerAngles);

    }
}
