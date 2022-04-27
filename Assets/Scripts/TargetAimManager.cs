using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetAimManager : MonoBehaviour
{
    Transform Ball;
    public Vector3 TargetAimPosition;
    [SerializeField] private GameObject _aimIconPrefabs;
    private GameObject _cloneIcon;

    private void Awake()
    {
        VariableManager.targetAimManager = this;
        _aimIconPrefabs = Resources.Load<GameObject>("Prefabs/AimTarget");  
    }



    private void Update()
    {
        RefreshAimAngle();
        

    }

    public void InstantiateAimTarget()
    {
        if(VariableManager.gameCheckerCollider.IsReadyToThrow == true)
        {
        _cloneIcon = Object.Instantiate<GameObject>(_aimIconPrefabs, VariableManager.gameCheckerCollider.FirstBallLocationOnGameCheckerCollider.position, Quaternion.identity,VariableManager.ballManager.FirstBallTransformHolder);
        }

    }


    public void RefreshAimAngle()
    {
        if(_cloneIcon != null)
        {
        _cloneIcon.transform.rotation = Quaternion.Euler(0, 0, VariableManager.math.VectorBetwenTwoPoint.w);
        }




    }

    public void DestroyAimTarget()
    {
        Destroy(_cloneIcon);
    }


   
}

