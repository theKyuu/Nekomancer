using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IInputHandler
{
    public float MovementSpeed = 0.5f;
    private Vector3 MovementDirection;
    private Animator anim;
    public ActionListener CurrentInteract;

    public void TakeInput(InputData inputData)
    {
        MovementDirection = inputData.DirectionToVector();
        if (inputData.ActionButton)
        {
            if (CurrentInteract)
            {
                CurrentInteract.Activate();
            }
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("!");
    }

    public void SetInteract(ActionListener act)
    {
        CurrentInteract = act;
    }

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        if (MovementDirection != Vector3.zero)
        {
            anim.SetBool("Moving", true);
            anim.SetFloat("Input_X", MovementDirection.x);
            anim.SetFloat("Input_Y", MovementDirection.y);
        }
        else
        {
            anim.SetBool("Moving", false);
        }
        transform.Translate(MovementDirection * Time.deltaTime * MovementSpeed);
	}
}
