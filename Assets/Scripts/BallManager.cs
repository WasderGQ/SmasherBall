using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    public GameObject[] CloneBall;
    public Rigidbody2D[] RDBall;
    public int CloneBallArrayIndex;
    GameObject _prefabBall;
    Transform StartBallArea;
    public int SpawnDistanceForNewBall;
    public Vector3 FirstBallPositionHolder;

    private void Awake()
    {
        CloneBall = new GameObject[1000];
        RDBall = new Rigidbody2D[1000];
        VariableManager.ballManager = this;
        _prefabBall = Resources.Load<GameObject>("Prefabs/Ball");
        StartBallArea = GameObject.Find("FirstStartZone").transform;
        

    }

    void Start()
    {
        FirtBallSpawn(StartBallArea.position);
    }

    
    void Update()
    {
        FirstBallPositionTracker();
        RepeatSpawn(CloneBall[CloneBallArrayIndex].transform.position);
    }



public void FirtBallSpawn(Vector3 SpawnLocation)
    {
        if(AmISpawnFirstBall())
        {
            CloneBall[0] = Instantiate<GameObject>(_prefabBall, SpawnLocation, Quaternion.identity, VariableManager.resolutionManager.Game_Canvas.transform);
            RDBall[0] = CloneBall[0].GetComponent<Rigidbody2D>();
            CloneBall[0].gameObject.GetComponent<Ball>().ID = 0;
        }
        
         
    }


    public bool AmISpawnFirstBall()
    {
        if(CloneBall[0] == null)
        {
            return true;


        }
        else
        {
            return false;

        }


    }

    public void FirstBallPositionTracker()
    {
        if(CloneBall[0] != null)
        {
        FirstBallPositionHolder = CloneBall[0].transform.position;
        Debug.Log(FirstBallPositionHolder); //*consolda bulunduðu konum kordinatlarýný almýþ olursun*
        }
        


    }



    public void BallSpawn(Vector3 SpawnLocation)
    {     
    CloneBall[CloneBallArrayIndex] = Instantiate<GameObject>(_prefabBall, SpawnLocation, Quaternion.identity, VariableManager.resolutionManager.Game_Canvas.transform);
    RDBall[CloneBallArrayIndex] = CloneBall[CloneBallArrayIndex].GetComponent<Rigidbody2D>();
    CloneBall[CloneBallArrayIndex].gameObject.GetComponent<Ball>().ID = CloneBallArrayIndex;  
    }

}


