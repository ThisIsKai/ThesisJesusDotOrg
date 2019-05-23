using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingInfo : MonoBehaviour
{
    public enum Letter
    {
        a,
        b,
        c,
        d
    }
    public enum Height
    {
        superSmall,
        small,
        medium,
        tall,
        superTall

    }

    public Letter letter;
    public Height height;


}
