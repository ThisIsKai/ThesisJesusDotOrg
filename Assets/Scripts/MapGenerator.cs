using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MapGenerator : MonoBehaviour
{
    public TextAsset mapText;
    public TextAsset mapTextLevel1;
    public TextAsset mapTextLevel2;
    public TextAsset mapTextLevel3;
    public TextAsset mapTextLevel4;
    public TextAsset mapTextLevel5;
    public TextAsset mapTextLevel6;
    public TextAsset mapTextLevel7;
    public Vector3 mapOffset;
    public GameObject floorPrefab;
    public GameObject holePrefab;
    public GameObject buildingPrefab;
    public BuildingInfo[] buildings;
    public List<Vector2>[] letters;
    public List<Vector2>[] heights;
    private Scene thisScene;


    // Start is called before the first frame update
    void Start()
    {
       thisScene = SceneManager.GetActiveScene();
       
         if (thisScene.name == "Level1")
        {
            MakeLevel1();
        }
        if (thisScene.name == "Level2")
        {
            MakeLevel2();
        }
        if (thisScene.name == "Level3")
        {
            MakeLevel3();
        }
        if (thisScene.name == "Level4")
        {
            MakeLevel4();
        }
        if (thisScene.name == "Level5")
        {
            MakeLevel5();
        }
        if (thisScene.name == "Level6")
        {
            MakeLevel6();
        }
        if (thisScene.name == "Level7")
        {
            MakeLevel7();
        }
    }


    void MakeLevel1()
    {
        string[] mapLines = mapTextLevel1.text.Split(
           new string[] { "\r\n", "\r", "\n" }, System.StringSplitOptions.RemoveEmptyEntries);
        BuildingBaseScript[,] buildingGrid = new BuildingBaseScript[mapLines[0].Length, mapLines.Length];

        for (int x = 0; x < mapLines[0].Length; x++)
        {
            for (int y = 0; y < mapLines.Length; y++)
            {
                if (mapLines[y][x] == '-')
                {
                    Instantiate(floorPrefab, new Vector3(x, mapLines.Length - y - 1) + mapOffset, Quaternion.identity);
                }
                else if (mapLines[y][x] == 'X')
                {
                    Instantiate(holePrefab, new Vector3(x, mapLines.Length - y - 1) + mapOffset, Quaternion.identity);
                }
                else if (mapLines[y][x] == 'B')
                {
                    GameManager.Instance.goalsInLevel++;
                    GameManager.Instance.goalsRemaining++;
                    GameObject obj = Instantiate(buildingPrefab, new Vector3(x, mapLines.Length - y - 1) + mapOffset, buildingPrefab.transform.rotation);
                    buildingGrid[x, y] = obj.GetComponent<BuildingBaseScript>();
                }

            }
        }

    }
    void MakeLevel2()
    {
        string[] mapLines = mapTextLevel2.text.Split(
           new string[] { "\r\n", "\r", "\n" }, System.StringSplitOptions.RemoveEmptyEntries);
        BuildingBaseScript[,] buildingGrid = new BuildingBaseScript[mapLines[0].Length, mapLines.Length];

        for (int x = 0; x < mapLines[0].Length; x++)
        {
            for (int y = 0; y < mapLines.Length; y++)
            {
                if (mapLines[y][x] == '-')
                {
                    Instantiate(floorPrefab, new Vector3(x, mapLines.Length - y - 1) + mapOffset, Quaternion.identity);
                }
                else if (mapLines[y][x] == 'X')
                {
                    Instantiate(holePrefab, new Vector3(x, mapLines.Length - y - 1) + mapOffset, Quaternion.identity);
                }
                else if (mapLines[y][x] == 'B')
                {
                    GameManager.Instance.goalsInLevel++;
                    GameManager.Instance.goalsRemaining++;
                    GameObject obj = Instantiate(buildingPrefab, new Vector3(x, mapLines.Length - y - 1) + mapOffset, buildingPrefab.transform.rotation);
                    buildingGrid[x, y] = obj.GetComponent<BuildingBaseScript>();
                }

            }
        }

    }
    void MakeLevel3()
    {
        string[] mapLines = mapTextLevel3.text.Split(
           new string[] { "\r\n", "\r", "\n" }, System.StringSplitOptions.RemoveEmptyEntries);
        BuildingBaseScript[,] buildingGrid = new BuildingBaseScript[mapLines[0].Length, mapLines.Length];

        for (int x = 0; x < mapLines[0].Length; x++)
        {
            for (int y = 0; y < mapLines.Length; y++)
            {
                if (mapLines[y][x] == '-')
                {
                    Instantiate(floorPrefab, new Vector3(x, mapLines.Length - y - 1) + mapOffset, Quaternion.identity);
                }
                else if (mapLines[y][x] == 'X')
                {
                    Instantiate(holePrefab, new Vector3(x, mapLines.Length - y - 1) + mapOffset, Quaternion.identity);
                }
                else if (mapLines[y][x] == 'B')
                {
                    GameManager.Instance.goalsInLevel++;
                    GameManager.Instance.goalsRemaining++;
                    GameObject obj = Instantiate(buildingPrefab, new Vector3(x, mapLines.Length - y - 1) + mapOffset, buildingPrefab.transform.rotation);
                    buildingGrid[x, y] = obj.GetComponent<BuildingBaseScript>();
                }

            }
        }

    }
    void MakeLevel4()
    {
        string[] mapLines = mapTextLevel4.text.Split(
           new string[] { "\r\n", "\r", "\n" }, System.StringSplitOptions.RemoveEmptyEntries);
        BuildingBaseScript[,] buildingGrid = new BuildingBaseScript[mapLines[0].Length, mapLines.Length];

        for (int x = 0; x < mapLines[0].Length; x++)
        {
            for (int y = 0; y < mapLines.Length; y++)
            {
                if (mapLines[y][x] == '-')
                {
                    Instantiate(floorPrefab, new Vector3(x, mapLines.Length - y - 1) + mapOffset, Quaternion.identity);
                }
                else if (mapLines[y][x] == 'X')
                {
                    Instantiate(holePrefab, new Vector3(x, mapLines.Length - y - 1) + mapOffset, Quaternion.identity);
                }
                else if (mapLines[y][x] == 'B')
                {
                    GameManager.Instance.goalsInLevel++;
                    GameManager.Instance.goalsRemaining++;
                    GameObject obj = Instantiate(buildingPrefab, new Vector3(x, mapLines.Length - y - 1) + mapOffset, buildingPrefab.transform.rotation);
                    buildingGrid[x, y] = obj.GetComponent<BuildingBaseScript>();
                }

            }
        }

    }
    void MakeLevel5()
    {
        string[] mapLines = mapTextLevel5.text.Split(
           new string[] { "\r\n", "\r", "\n" }, System.StringSplitOptions.RemoveEmptyEntries);
        BuildingBaseScript[,] buildingGrid = new BuildingBaseScript[mapLines[0].Length, mapLines.Length];

        for (int x = 0; x < mapLines[0].Length; x++)
        {
            for (int y = 0; y < mapLines.Length; y++)
            {
                if (mapLines[y][x] == '-')
                {
                    Instantiate(floorPrefab, new Vector3(x, mapLines.Length - y - 1) + mapOffset, Quaternion.identity);
                }
                else if (mapLines[y][x] == 'X')
                {
                    Instantiate(holePrefab, new Vector3(x, mapLines.Length - y - 1) + mapOffset, Quaternion.identity);
                }
                else if (mapLines[y][x] == 'B')
                {
                    GameManager.Instance.goalsInLevel++;
                    GameManager.Instance.goalsRemaining++;
                    GameObject obj = Instantiate(buildingPrefab, new Vector3(x, mapLines.Length - y - 1) + mapOffset, buildingPrefab.transform.rotation);
                    buildingGrid[x, y] = obj.GetComponent<BuildingBaseScript>();
                }

            }
        }

    }
    void MakeLevel6()
    {
        string[] mapLines = mapTextLevel6.text.Split(
           new string[] { "\r\n", "\r", "\n" }, System.StringSplitOptions.RemoveEmptyEntries);
        BuildingBaseScript[,] buildingGrid = new BuildingBaseScript[mapLines[0].Length, mapLines.Length];

        for (int x = 0; x < mapLines[0].Length; x++)
        {
            for (int y = 0; y < mapLines.Length; y++)
            {
                if (mapLines[y][x] == '-')
                {
                    Instantiate(floorPrefab, new Vector3(x, mapLines.Length - y - 1) + mapOffset, Quaternion.identity);
                }
                else if (mapLines[y][x] == 'X')
                {
                    Instantiate(holePrefab, new Vector3(x, mapLines.Length - y - 1) + mapOffset, Quaternion.identity);
                }
                else if (mapLines[y][x] == 'B')
                {
                    GameManager.Instance.goalsInLevel++;
                    GameManager.Instance.goalsRemaining++;
                    GameObject obj = Instantiate(buildingPrefab, new Vector3(x, mapLines.Length - y - 1) + mapOffset, buildingPrefab.transform.rotation);
                    buildingGrid[x, y] = obj.GetComponent<BuildingBaseScript>();
                }

            }
        }

    }
    void MakeLevel7()
    {
        string[] mapLines = mapTextLevel7.text.Split(
           new string[] { "\r\n", "\r", "\n" }, System.StringSplitOptions.RemoveEmptyEntries);
        BuildingBaseScript[,] buildingGrid = new BuildingBaseScript[mapLines[0].Length, mapLines.Length];

        for (int x = 0; x < mapLines[0].Length; x++)
        {
            for (int y = 0; y < mapLines.Length; y++)
            {
                if (mapLines[y][x] == '-')
                {
                    Instantiate(floorPrefab, new Vector3(x, mapLines.Length - y - 1) + mapOffset, Quaternion.identity);
                }
                else if (mapLines[y][x] == 'X')
                {
                    Instantiate(holePrefab, new Vector3(x, mapLines.Length - y - 1) + mapOffset, Quaternion.identity);
                }
                else if (mapLines[y][x] == 'B')
                {
                    GameManager.Instance.goalsInLevel++;
                    GameManager.Instance.goalsRemaining++;
                    GameObject obj = Instantiate(buildingPrefab, new Vector3(x, mapLines.Length - y - 1) + mapOffset, buildingPrefab.transform.rotation);
                    buildingGrid[x, y] = obj.GetComponent<BuildingBaseScript>();
                }

            }
        }

    }

}
