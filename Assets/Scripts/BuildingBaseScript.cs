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
    public bool buildingHasBeenHit;
    public AudioClip[] buildingHitClips;
  
    public AudioSource myAudioSource;
    private AudioClip myClip;


    void Start()
    {
        myAudioSource = GetComponent<AudioSource>();
        int num = Random.Range(0, buildingPrefabs.Length);
        myBuilding = Instantiate(buildingPrefabs[num], transform.position, buildingPrefabs[num].transform.rotation);
    }


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
        if (buildingHasBeenHit == true)
        {
            int index = Random.Range(0, buildingHitClips.Length);
            myClip = buildingHitClips[index];
            myAudioSource.clip = myClip;
            myAudioSource.Play();
           // Debug.Log("I'mSupposedToBePlayingMyHitClip");
            buildingHasBeenHit = false;

        }
    }


    private void OnTriggerEnter(Collider other)
    {
      myBuilding.GetComponentInChildren<VisualEffectsScript>().enabled = true;
        GetComponent<Collider>().enabled = false;
        flashing = true;
        GameManager.Instance.goalsRemaining--;
        buildingHasBeenHit = true;
    }

}
