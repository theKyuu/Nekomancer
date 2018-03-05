using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputData
{
    [System.Flags]
    public enum Direction: uint
    {
        None    = 0,
        Up      = 1,
        Down    = 2,
        Left    = 4,
        Right   = 8
    }

    public Direction MovementDirection;
    public bool ActionButton;

    public Vector3 DirectionToVector()
    {
        var result = Vector3.zero;

        if((MovementDirection & Direction.Up) > 0)
        {
            result.y = 1;
        }

        if ((MovementDirection & Direction.Down) > 0)
        {
            result.y = -1;
        }

        if ((MovementDirection & Direction.Left) > 0)
        {
            result.x = -1;
        }

        if ((MovementDirection & Direction.Right) > 0)
        {
            result.x = 1;
        }

        return result;
    }
}
