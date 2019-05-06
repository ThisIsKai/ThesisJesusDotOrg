using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JitterMovementScript : MonoBehaviour
{
    public float min_X_rand;
    public float max_X_rand;
    public float min_Y_rand;
    public float max_Y_rand;
    public float min_Z_rand;
    public float max_Z_rand;
    float randomizerX;
    float randomizerY;
    float randomizerZ;
   public float baseX;
   public float baseY;
   public float baseZ;
  Vector3 myTransform;




    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.transform.position = myTransform;
        myTransform.x = baseX;
        myTransform.y = baseY;
        myTransform.z = baseZ;
       
    }

    // Update is called once per frame
    void Update()
    {
       randomizerX = Random.Range(min_X_rand, max_X_rand);
       randomizerY = Random.Range(min_Y_rand, max_Y_rand);
       randomizerZ = Random.Range(min_Z_rand, max_Z_rand);

        var pos = this.gameObject.transform.position;
        pos.x = baseX + randomizerX;
        pos.y = baseY + randomizerY;
        pos.z = baseZ + randomizerZ;
        this.gameObject.transform.position = pos;


    }
}
