using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResolationManager : MonoBehaviour
{
    Resolution[] resolutions;
   public int ResWidth;
   public int ResHeigt;




private void Awake()
    {
        resolutions  = Screen.resolutions;
        FixBackGroundResolation();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    void FixBackGroundResolation()
    {

        foreach (var res in resolutions)
        {
            ResWidth = res.width;
            ResHeigt = res.height;
           
          
          Debug.Log(res.width + "x" + res.height + " : " + res.refreshRate);
            
        }

    }
}
