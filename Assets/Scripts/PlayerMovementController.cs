using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    [SerializeField] private float movementSpeed;

    public void DoMoveAxis(float horizontalAxis, float verticalAxis)
    {
        transform.Translate(new Vector3(horizontalAxis ,0f , verticalAxis) * movementSpeed * Time.deltaTime);
    }

}
