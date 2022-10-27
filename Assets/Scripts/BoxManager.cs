using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BoxManager : MonoBehaviour
{
    public GameObject[] BoxSpawnLocations;
    public GameObject[] CloneBox;
    int CloneBoxIndex;
    GameObject _prefabBox;
    int IntimeHowMuchBoxWillSpawn;
    GameObject[] CloneBoxSpawnPositions;
    int[] EveryLevelSpawnBox

    private void Awake()
    {
        _prefabBox = Resources.Load<GameObject>("Prefabs/Box");
        CloneBox = new GameObject[100];
        BoxSpawnLocations = new GameObject[7];
        FindBoxSpawnPosition();
        
    }

    void Start()
    {
       
    }

    
    void Update()
    {
        
    }



   /* void SpawnBox()
    {
        HowMuchBox();
        CloneBox[CloneBoxIndex]=Instantiate(_prefabBox,)


    }*/




    public void HowMuchBox()
    {
        IntimeHowMuchBoxWillSpawn =  VariableManager.math.RandomNumber(0, 6);
        

    }

    void WhichPosition()
    {
        for(int i=0;i>IntimeHowMuchBoxWillSpawn;i++)
        {
            CloneBoxSpawnPositions = new GameObject[IntimeHowMuchBoxWillSpawn];



        }



    }
















    public void FindBoxSpawnPosition()
    {
        BoxSpawnLocations[0] = GameObject.Find("Position_Checker_1");
        BoxSpawnLocations[1] = GameObject.Find("Position_Checker_2");
        BoxSpawnLocations[2] = GameObject.Find("Position_Checker_3");
        BoxSpawnLocations[3] = GameObject.Find("Position_Checker_4");
        BoxSpawnLocations[4] = GameObject.Find("Position_Checker_5");
        BoxSpawnLocations[5] = GameObject.Find("Position_Checker_6");
        BoxSpawnLocations[6] = GameObject.Find("Position_Checker_7");
    }












}


