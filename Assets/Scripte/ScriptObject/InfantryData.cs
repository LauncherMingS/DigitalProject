using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Object/InfantryData", fileName = "InfantryData", order = 3)]
public class InfantryData : UnitData
{
    public float atkDamage;
    public float atkFrequence;
    public float atkRange;

    public float detectRangeOnAtk;
    public float detectRangeOnDef;
}