using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public KeyCode UpKey = KeyCode.W;
    public KeyCode DownKey = KeyCode.S;
    public KeyCode LeftKey = KeyCode.A;
    public KeyCode RightKey = KeyCode.D;

    public KeyCode ActionButton = KeyCode.Return;

    public Player DefaultHandlerObject;
    public IInputHandler CurrentHandler;

	// Use this for initialization
	void Start ()
    {
		if(DefaultHandlerObject == null)
        {
            return;
        }

        CurrentHandler = DefaultHandlerObject.GetInterface<IInputHandler>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        var currentInput = new InputData();

        if (Input.GetKey(UpKey))
        {
            currentInput.MovementDirection |= InputData.Direction.Up;
        }
        if (Input.GetKey(DownKey))
        {
            currentInput.MovementDirection |= InputData.Direction.Down;
        }
        if (Input.GetKey(LeftKey))
        {
            currentInput.MovementDirection |= InputData.Direction.Left;
        }
        if (Input.GetKey(RightKey))
        {
            currentInput.MovementDirection |= InputData.Direction.Right;
        }

        currentInput.ActionButton = Input.GetKeyDown(ActionButton);
        CurrentHandler = DefaultHandlerObject.GetInterface<IInputHandler>();

        if(CurrentHandler != null)
        {
            CurrentHandler.TakeInput(currentInput);
        }
    }
}
