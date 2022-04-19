using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(menuName = "Value Holder")]
public class ValueHolder : ScriptableObject
{
    public int Level;

    private void Awake()
    {

        VariableManager.valueHolder = this;


    }

}
