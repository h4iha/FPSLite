using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInputController : MonoBehaviour
{
    public Action<float> onHorizontalMoved;
    public Action onLeftMouseClicked;


    public UnityEvent onHorizontalMovedUE;

    private float lastHorizontalAxisValue;

    private void Update()
    {
        if(lastHorizontalAxisValue != Input.GetAxis("Horizontal"))
        {
            onHorizontalMoved?.Invoke(Input.GetAxis("Horizontal"));
        }

        if (Input.GetMouseButtonDown(0))
        {
            onLeftMouseClicked?.Invoke();
        }
    }
}
