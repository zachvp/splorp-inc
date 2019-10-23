using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ControlData", menuName = "Data/ControlData", order = 1)]
public class ControlData : ScriptableObject
{
   [SerializeField]
    public ControlState state;
}
