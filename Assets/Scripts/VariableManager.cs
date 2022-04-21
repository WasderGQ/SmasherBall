using System.Collections;
using System.Collections.Generic;


public class VariableManager 
{
    public static GameManager gameManager;
    public static ControllerManager controllerManager;
    public static Math math;
    public static BallManager ballManager;
    public static TargetAimManager targetAimManager;
    public static BallThrowManager ballThrowManager;
    public static GameCheckerCollider gameCheckerCollider;
    public static ValueHolder valueHolder;
    public static Timer timer;
    public static BoxManager boxManager;
    public static ResolutionManager resolutionManager;
    public static BoxPositions BoxSpawnPositions;



}


public struct BoxPositions
{

    public float FirstPosition;
    public float SecondPosition;
    public float ThirdPosition;
    public float FourthPosition;
    public float FifthPosition;
    public float SixthPosition;


}