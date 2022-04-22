using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    public GameObject[] CloneBall;
    public Rigidbody2D[] RDBall;
    public int CloneBallArrayIndex ;
    GameObject _prefabBall;
    Transform StartBallArea;

    private void Awake()
    {
        CloneBall = new GameObject[10000];
        RDBall = new Rigidbody2D[10000];
        
        VariableManager.ballManager = this;
        _prefabBall = Resources.Load<GameObject>("Prefabs/Ball");
        StartBallArea = GameObject.Find("FirstStartZone").transform;
        

    }

    void Start()
    {
        AmISpawnFirstBall();
    }

    
    void Update()
    {
        
    }



public void BallIntantiate(Vector3 SpawnLocation)
    {
        
        CloneBall[CloneBallArrayIndex] = Instantiate<GameObject>(_prefabBall ,SpawnLocation, Quaternion.identity,VariableManager.resolutionManager.Game_Canvas.transform);
        RDBall[CloneBallArrayIndex] = CloneBall[CloneBallArrayIndex].GetComponent<Rigidbody2D>();
        CloneBall[CloneBallArrayIndex].gameObject.GetComponent<Ball>().ID = CloneBallArrayIndex;
        CloneBallArrayIndex++;
       
    }


    public void AmISpawnFirstBall()
    {
        if(CloneBall[0] == null)
        {
            BallIntantiate(StartBallArea.position);




        }



    }


}


