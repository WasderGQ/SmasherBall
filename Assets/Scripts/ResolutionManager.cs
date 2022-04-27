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
}
