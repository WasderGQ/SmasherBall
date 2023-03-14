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
    public Transform FirstBallTransformHolder;
    public bool CanIThrowNextBall;
    Transform t_GameCheckerCollider; 




    private void Awake()
    {
        CloneBall = new GameObject[1000];
        RDBall = new Rigidbody2D[1000];
        VariableManager.ballManager = this;
        _prefabBall = Resources.Load<GameObject>("Prefabs/Ball");
        StartBallArea = GameObject.Find("FirstStartZone").transform;
        t_GameCheckerCollider = GameObject.Find("Down - GameSpaceLimit").GetComponent<Transform>();

    }

    void Start()
    {
        FirtBallSpawn(StartBallArea.position);
    }

    
    void Update()
    {
        FirstBallTransformTracker();
        BallSpawnCheckPoint();
        CanIThrowCloneBallsChecker();
    }



    public void FirtBallSpawn(Vector3 SpawnLocation)
    {
        if (CloneBall[0]==null)
        {
            CloneBall[0] = Instantiate<GameObject>(_prefabBall, SpawnLocation, Quaternion.identity, VariableManager.resolutionManager.Game_Canvas.transform);
            RDBall[0] = CloneBall[0].GetComponent<Rigidbody2D>();
            //CloneBall[0].gameObject.GetComponent<Ball>().ID = 0;   
            
        }
    
         
    }

    public void BallSpawn(Vector3 SpawnLocation)
    {     
    CloneBall[CloneBallArrayIndex] = Instantiate<GameObject>(_prefabBall, SpawnLocation, Quaternion.identity, VariableManager.resolutionManager.Game_Canvas.transform);
    RDBall[CloneBallArrayIndex] = CloneBall[CloneBallArrayIndex].GetComponent<Rigidbody2D>();
   // CloneBall[CloneBallArrayIndex].gameObject.GetComponent<Ball>().ID = CloneBallArrayIndex;
    
    }

   
    
    
    
    public void FirstBallTransformTracker()
    {
        if (CloneBall[0] != null)
        {
            FirstBallTransformHolder = CloneBall[0].transform;

        }
    }



    public void BallSpawnCheckPoint()
    {
        if (CloneBall[CloneBallArrayIndex] != null)
        {
            if (CloneBall[CloneBallArrayIndex].transform.position.y >= t_GameCheckerCollider.position.y + 2)
            {

                CanIThrowNextBall = true;
                CloneBallArrayIndex++;
                Debug.Log(CanIThrowNextBall);
                VariableManager.gameManager.LevelUpCounter();

            }
            else
            {

                CanIThrowNextBall = false;

            }

        }
        
        

        
    }


    public void CanIThrowCloneBallsChecker()
    {
        if(CloneBallArrayIndex == VariableManager.gameManager.TempLevelHolder - 1)
        {
            VariableManager.ballThrowManager.CanIThrowCloneBalls = false;

            CloneBallArrayIndex = 1;





        }




    }


}











