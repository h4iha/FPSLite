using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    [SerializeField] private Rigidbody rigidbody;
    [SerializeField] private float movementSpeed;
    private void Start()
    {
        movementSpeed = 3f;
    }
    public void DoMoveAxis(float horizontalAxis, float verticalAxis)
    {
        rigidbody.MovePosition(transform.position + new Vector3(horizontalAxis, 0f, verticalAxis) * movementSpeed * Time.deltaTime);
        //transform.Translate(new Vector3(horizontalAxis ,0f , verticalAxis) * movementSpeed * Time.deltaTime);
    }

}
