﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    public TextAsset mapText;
    public Vector3 mapOffset;
    public GameObject floorPrefab;
    public GameObject holePrefab;
    public GameObject buildingPrefab;
    public BuildingInfo[] buildings;
    //public List<Vector2>[



    // Start is called before the first frame update
    void Start()
    {
        string[] mapLines = mapText.text.Split(
           new string[] { "\r\n", "\r", "\n" }, System.StringSplitOptions.RemoveEmptyEntries);
        BuildingBaseScript[,] buildingGrid = new BuildingBaseScript[mapLines[0].Length, mapLines.Length];
        for (int x = 0; x < mapLines[0].Length; x++)
        {
            for (int y = 0; y < mapLines.Length; y++)
            {
                if (mapLines[y][x] == '-')
                {
                    Instantiate(floorPrefab, new Vector3(x, mapLines.Length - y - 1) + mapOffset, Quaternion.identity);
                } else if (mapLines[y][x] == 'X') 
                {
                    Instantiate(holePrefab, new Vector3(x, mapLines.Length - y - 1) + mapOffset, Quaternion.identity);
                }else if (mapLines[y][x] == 'B') 
                {
                    GameObject obj = Instantiate(buildingPrefab, new Vector3(x, mapLines.Length - y - 1) + mapOffset, buildingPrefab.transform.rotation);
                    buildingGrid[x, y] = obj.GetComponent<BuildingBaseScript>();
                }

            }
        }

        for (int x = 0; x < buildingGrid.GetLength(0); x++)
        {
            for (int y = 0; y < buildingGrid.GetLength(1); y++)
            {

            }
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}