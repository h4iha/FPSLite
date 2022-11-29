using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLookController : MonoBehaviour
{
    public void DoRotate(float mouseXAxis, float mouseYAxis)
    {
        transform.Rotate(0f, mouseXAxis, 0f);
        Camera.main.transform.Rotate(-mouseYAxis, 0f, 0f);
    }
}
