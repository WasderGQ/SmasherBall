using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimTargetIcon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RefreshAimAngle();
    }




    public void RefreshAimAngle()
    {


        this.gameObject.transform.position = new Vector3(VariableManager.math.VectorBetwenTwoPoint.x + VariableManager.ballManager.CloneBall[0].transform.position.x, VariableManager.math.VectorBetwenTwoPoint.y + VariableManager.ballManager.CloneBall[0].transform.position.y, VariableManager.math.VectorBetwenTwoPoint.z);



    }
}
