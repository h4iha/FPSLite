using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputMouseController : MonoBehaviour
{
    [SerializeField] UnityEvent<Vector3> mousePositionChanged;

    [SerializeField] UnityEvent<Vector3> mousePositionUpdate;
    [SerializeField] UnityEvent leftMouseClicked;
    [SerializeField] UnityEvent rightMouseClicked;

    private Vector3 lastMousePosition;

    // Update is called once per frame
    void Update()
    {
        mousePositionUpdate?.Invoke(Input.mousePosition);

        if (lastMousePosition != Input.mousePosition)
        {
            lastMousePosition = Input.mousePosition;
            mousePositionChanged?.Invoke(lastMousePosition);
        }

        if (Input.GetMouseButtonDown(0))
        {
            leftMouseClicked?.Invoke();
        }
        if (Input.GetMouseButtonDown(1))
        {
            rightMouseClicked?.Invoke();
        }
    }
}
