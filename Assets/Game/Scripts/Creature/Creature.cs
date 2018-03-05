using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature : MonoBehaviour
{
    public CreatureType Type;
    public int CurrentLevel = 0;
    public int CurrentHealth;

    void Start()
    {
        if (CurrentLevel == 0)
        {
            CurrentLevel = Random.Range(Type.MinLevel, Type.Levels.Capacity);
        }
        CurrentHealth = Type.Levels[CurrentLevel].Stats.MaxHealth;
    }

    public void SetLevel(int lvl)
    {
        CurrentLevel = lvl;
        CurrentHealth = Type.Levels[CurrentLevel].Stats.MaxHealth;
    }
}
