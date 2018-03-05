using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new creature", menuName = "Nekomancer/Creatures")]
public class CreatureType: ScriptableObject
{
    public int MinLevel = 1;
    public List<Level> Levels;
    public List<MoveBase> AvailableMoves;
    public GameObject RelatedCorpse;
    public GameObject RelatedMinion;
}
