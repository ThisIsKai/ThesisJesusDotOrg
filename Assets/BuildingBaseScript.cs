using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingBaseScript : MonoBehaviour
{

    public GameObject[] buildingPrefabs;
    private GameObject myBuilding;
    public GameObject holePrefab;
    public float flashTimer = 180f;
    private bool flashing;
    // Start is called before the first frame update
    void Start()
    {
        //myBuilding = Instantiate(buildingPrefabs[0], transform.position, buildingPrefabs[0].transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (flashing)
        {
            flashTimer -= Time.deltaTime * 60f;
            if (flashTimer <= 0)
            {
                Instantiate(holePrefab, transform.position, Quaternion.identity);
                Destroy(gameObject);
                Destroy(myBuilding);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        myBuilding.GetComponentInChildren<VisualEffectsScript>().enabled = true;
        GetComponent<Collider>().enabled = false;
        flashing = true;
    }

}
