using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpController : MonoBehaviour
{
    [SerializeField] private Rigidbody rigidbody;
    [SerializeField] private bool isGrounded;
    public void DoJump()
    {
        //rigidbody.AddForce();
    }
    public void OnCollisionStay()
    {
        isGrounded = true;
    }
}
