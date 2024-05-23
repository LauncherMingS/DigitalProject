using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Object/CollectorData", fileName = "CollectorData", order = 2)]
public class CollectorData : UnitData
{
    public int collectAmout;
    public float collectFrequence;
    public int maxCarry;
    public float resourceDetectRange;
    public float conveyDistance;
}
