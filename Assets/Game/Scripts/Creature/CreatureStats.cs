using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct CreatureStats
{
    [Tooltip("Max health of the creature")]
    public int MaxHealth;
    [Tooltip("Determines turn order in combat")]
    public int Speed;
    [Tooltip("Affects damage dealt with most physical attacks")]
    public int PhysicalStrength;
    [Tooltip("Lowers damage taken from most physical attacks")]
    public int PhysicalDefense;
    // TODO: More!
}
