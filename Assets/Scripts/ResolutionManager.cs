using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResolutionManager : MonoBehaviour
{
   private Resolution[] resolutions;
   private int ScreenResolationWidth;
   private int ScreenResolationHeight;
   Vector3 GameCanvasLocalScale;
   private Vector2 NewSizeOfBox;
   private Vector2 NormalSizeRatio;
   public GameObject Game_Canvas;
private void Awake()
    {
        Game_Canvas = GameObject.Find("Game_Canvas");
        VariableManager.resolutionManager = this;
     
    }

    void Start()
    {
        GameCanvasLocalScale = Game_Canvas.GetComponent<RectTransform>().localScale;
      
    }

    
    void Update()
    {
        
    }
    // bu dizenin altýndaki bütün kodlar rafa kaldýrýlmýþtýr.
    /*

    void FixBackGroundResolation()
    {

        foreach (var res in resolutions)
        {
            ScreenResolationWidth = res.width;
            ScreenResolationHeight = res.height;
            
        }

    }

    void FixedBoxCoordinateOnCanvas()
    {
        float tempValue = ScreenResolationWidth / 6;
        float tempvalue2 = (150/2) + 90 * GameCanvasLocalScale.x;
        //Debug.Log(tempvalue2);
         VariableManager.BoxSpawnPositions.FirstPosition = tempValue / 2 + 90 * GameCanvasLocalScale.x;
         VariableManager.BoxSpawnPositions.SecondPosition = VariableManager.BoxSpawnPositions.FirstPosition + tempValue;
         VariableManager.BoxSpawnPositions.ThirdPosition = VariableManager.BoxSpawnPositions.SecondPosition + tempValue;
         VariableManager.BoxSpawnPositions.FourthPosition = VariableManager.BoxSpawnPositions.ThirdPosition + tempValue;
         VariableManager.BoxSpawnPositions.FifthPosition = VariableManager.BoxSpawnPositions.FourthPosition + tempValue;
         VariableManager.BoxSpawnPositions.SixthPosition = VariableManager.BoxSpawnPositions.FifthPosition + tempValue;

        

    }

    void ReScaleBoxSize()
    {
       NormalSizeRatio =new Vector2(1080/150, 1920/150);
        NewSizeOfBox.x = ScreenResolationWidth / NormalSizeRatio.x;
        NewSizeOfBox.y = ScreenResolationHeight / NormalSizeRatio.y;
        Debug.Log (ScreenResolationWidth + ScreenResolationHeight);
        Debug.Log(NewSizeOfBox.x+ NewSizeOfBox.y);


    }

    */
}
