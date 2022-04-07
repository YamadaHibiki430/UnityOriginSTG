using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : SingletonMonoBehaviour<InputManager>
{
    public bool Left_AxisUp { get; private set; }

    public bool Left_AxisDown { get; private set; }

    public bool Left_AxisRight { get; private set; }

    public bool Left_AxisLeft { get; private set; }

    public bool IsUpMoveKey { get; private set; }

    public bool IsDownMoveKey { get; private set; }

    public bool IsRightMoveKey { get; private set; }

    public bool IsLeftMoveKey { get; private set; }

    public bool IsLShiftKey { get; private set; }

    private void Update()
    {
        Left_AxisUp = Input.GetAxis("Vertical") > 0 ? true : false;

        Left_AxisDown = Input.GetAxis("Vertical") < 0 ? true : false;

        Left_AxisRight = Input.GetAxis("Horizontal") > 0 ? true : false;

        Left_AxisLeft = Input.GetAxis("Horizontal") < 0 ? true : false;

        IsUpMoveKey = Input.GetKey(KeyCode.UpArrow) | Input.GetKey(KeyCode.W) | Left_AxisUp;

        IsDownMoveKey = Input.GetKey(KeyCode.DownArrow) | Input.GetKey(KeyCode.S) | Left_AxisDown;

        IsRightMoveKey = Input.GetKey(KeyCode.RightArrow) | Input.GetKey(KeyCode.D) | Left_AxisRight;

        IsLeftMoveKey = Input.GetKey(KeyCode.LeftArrow) | Input.GetKey(KeyCode.A) | Left_AxisLeft;

        IsLShiftKey = Input.GetKey(KeyCode.LeftShift);
    }
}